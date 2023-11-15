using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service;
using NZZ.TSIM.WinApp.Internal.Models;
using NZZ.TSIM.WinApp.Models;
using NZZ.TSIM.WinApp.Statics;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace NZZ.TSIM.WinApp
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      HistoryTypes = new ObservableCollection<HistoryType>(new List<HistoryType>()
      {
        new HistoryType{ Key = "day", Text = "Tag (Watt)" },
        new HistoryType{ Key = "month", Text = "Monat (kWh)" },
        new HistoryType{ Key = "year", Text = "Jahr (kWh)" }
      });

      InitializeComponent();
    }

    private AppSettings AppSettings { get; set; }
    private Connection ServiceConnection { get; set; }

    private ObservableCollection<Station>? Stations { get; set; }
    private Station? SelectedStation => (Station)CbStations.SelectedItem;
    private StationDetails? DetailsOfSelectedStation { get; set; }

    private ObservableCollection<HistoryType> HistoryTypes { get; set; }
    private HistoryType? SelectedHistoryType => (HistoryType)CbHistoryType.SelectedItem;

    private bool _isBusy = false;
    private bool IsBusy
    {
      get => _isBusy;
      set
      {
        this.Enabled = !value;
        this._isBusy = value;
      }
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      try
      {
        IsBusy = true;

        if (!Directory.Exists(AppDataPath.LogFolderPath))
          Directory.CreateDirectory(AppDataPath.LogFolderPath);

        AppSettings = ConfigFile.LoadSettings();
        ServiceConnection = new Connection(AppSettings.Service, AppDataPath.LogFolderPath);

        TbServiceUserName.Text = Properties.Settings.Default.LastUserName;

        if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastPassword))
          TbServicePassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Properties.Settings.Default.LastPassword));

        if (AppSettings.AutoMaximizeAfterStart)
          this.WindowState = FormWindowState.Maximized;

        if (AppSettings.AutoLoginAfterStart &&
          !string.IsNullOrWhiteSpace(TbServiceUserName.Text) &&
          !string.IsNullOrWhiteSpace(TbServicePassword.Text))
          BtnConnect_Click(this, e);
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
      finally
      {
        IsBusy = false;
      }
    }

    private void SetMaskByConnectionState()
    {
      if (ServiceConnection.Connected)
      {
        PnHeader.Visible = false;
        PnBody.Visible = true;
        BtnOpenHistoryFolder.Visible = AppSettings.History.Enabled;

        this.Text = string.Format(Tag.ToString()!, $"Verbunden seit {DateTime.Now:HH:mm}");

        if (AppSettings.AutoSyncAfterLogin)
        {
          AddListBoxLogEntry("Automatische Synchronisation (5 Minuten) aktiviert...");
          TmAutoSync.Enabled = true;
        }
      }
      else
      {
        PnHeader.Visible = true;
        PnBody.Visible = false;

        this.Text = string.Format(Tag.ToString()!, "Nicht verbunden");

        TmAutoSync.Enabled = false;
      }
    }

    private void SetStationDetails(StationDetails stationDetails)
    {
      LbStationAddress.Text = stationDetails.Location;

      LbStationTimeStamp.Text = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
      LbStationActivePower.Text = stationDetails.ActivePowerNamed;

      LbStationCurrentEnergy.Text = stationDetails.CurrentDayEnergyNamed;
      LbStationTotalEnergy.Text = stationDetails.TotalEnergyNamed;

      CbHistoryType.DataSource = HistoryTypes;
    }

    private async Task LoadStationHistoryOfDay(Station station, DateTime date, bool onlyDataFromService)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      StationAggregationDay? data = null;

      if (!onlyDataFromService && AppSettings.History.Enabled && date < DateTime.Today)
        // Versuche Daten aus Backup zu laden
        data = HistoryBackup.GetAggregationOfDay(AppSettings.History.FolderPath, station.Guid, date);

      if (data == null)
      {
        // Versuche Daten von Service zu laden
        AddListBoxLogEntry($"Lade Daten für {date.ToLongDateString()}...");
        data = await Task.Run(() => ServiceConnection.GetStationAggregationOfDay(station, date));

        if (data == null)
        {
          AddListBoxLogEntry("Kommunikation T-SUN fehlgeschlagen, bitte erneut versuchen!");
          return;
        }

        if (AppSettings.History.Enabled)
          HistoryBackup.SaveAggregation(AppSettings.History.FolderPath, station.Guid, data);
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      ChartArea area = ChHistory.ChartAreas.Add("Day");
      area.AxisX.IntervalType = DateTimeIntervalType.Minutes;
      area.AxisX.Interval = 30;
      area.AxisY.Maximum = DetailsOfSelectedStation?.InstalledCapacity ?? 600D;

      Series series = ChHistory.Series.Add("Day");
      series.ChartArea = "Day";
      series.SetDefault(true);
      series.XValueType = ChartValueType.Time;
      series.YValueType = ChartValueType.Double;
      series.Enabled = true;
      series.ChartType = Enum.Parse<SeriesChartType>(AppSettings.Charts.DayChart.SeriesChartTypeName);
      series.BackGradientStyle = GradientStyle.TopBottom;
      series.BorderWidth = 2;
      series.IsXValueIndexed = true;
      series.IsValueShownAsLabel = true;
      series.BorderColor = Color.RoyalBlue;
      series.LabelForeColor = Color.RoyalBlue;
      series.LabelBackColor = Color.White;
      series.LabelBorderColor = Color.RoyalBlue;
      series.ShadowColor = Color.Empty;
      series.MarkerColor = Color.Navy;
      series.MarkerStyle = MarkerStyle.Diamond;
      series.MarkerSize = 5;

      DateTime beginOfDay = BuildTimeStamp(date, AppSettings.Charts.DayChart.VisibleAreaBegin);
      DateTime endOfDay = BuildTimeStamp(date, AppSettings.Charts.DayChart.VisibleAreaEnd);

      foreach (var item in data.Peaks.ChartEntries)
      {
        if (item.PointOfTime < beginOfDay || item.PointOfTime > endOfDay)
          continue;

        double value = Math.Round(item.PeakPower);
        var point = new DataPoint();
        point.SetValueXY(item.PointOfTime, value);
        //point.ToolTip = string.Format("{0} - {1}W", item.PointOfTime.ToShortTimeString(), value);
        series.Points.Add(point);
      }

      static DateTime BuildTimeStamp(DateTime originDateOfDay, TimeSpan timeToSet)
        => new DateTime(originDateOfDay.Year, originDateOfDay.Month, originDateOfDay.Day, timeToSet.Hours, timeToSet.Minutes, 0);
    }

    private async Task LoadStationHistoryOfMonth(string stationGuid, DateTime date, bool onlyDataFromService)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      StationAggregationMonth? data = await LoadStationAggregationOfMonth(stationGuid, date, onlyDataFromService);

      if (data == null)
        return;

      LbHistoryTotal.Text = data.TotalEnergy;

      ChartArea area = ChHistory.ChartAreas.Add("Month");
      area.AxisX.IntervalType = DateTimeIntervalType.Days;
      area.AxisX.Interval = 1;
      area.AxisX.LabelStyle = new LabelStyle() { Format = "dd" };

      Series series = ChHistory.Series.Add("Month");
      series.ChartArea = "Month";
      series.SetDefault(true);
      series.XValueType = ChartValueType.Date;
      series.YValueType = ChartValueType.Double;
      series.Enabled = true;
      series.ChartType = SeriesChartType.Column;
      series.BackGradientStyle = GradientStyle.TopBottom;
      series.BorderWidth = 2;
      series.IsXValueIndexed = true;
      series.IsValueShownAsLabel = true;
      series.BorderColor = Color.RoyalBlue;
      series.LabelForeColor = Color.RoyalBlue;
      series.LabelBackColor = Color.White;
      series.LabelBorderColor = Color.RoyalBlue;
      series.ShadowColor = Color.Empty;
      series.MarkerColor = Color.Navy;
      series.MarkerStyle = MarkerStyle.Diamond;
      series.MarkerSize = 10;

      // Echtdaten
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy1, nameof(data.DayEnergy1)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy2, nameof(data.DayEnergy2)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy3, nameof(data.DayEnergy3)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy4, nameof(data.DayEnergy4)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy5, nameof(data.DayEnergy5)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy6, nameof(data.DayEnergy6)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy7, nameof(data.DayEnergy7)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy8, nameof(data.DayEnergy8)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy9, nameof(data.DayEnergy9)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy10, nameof(data.DayEnergy10)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy11, nameof(data.DayEnergy11)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy12, nameof(data.DayEnergy12)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy13, nameof(data.DayEnergy13)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy14, nameof(data.DayEnergy14)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy15, nameof(data.DayEnergy15)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy16, nameof(data.DayEnergy16)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy17, nameof(data.DayEnergy17)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy18, nameof(data.DayEnergy18)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy19, nameof(data.DayEnergy19)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy20, nameof(data.DayEnergy20)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy21, nameof(data.DayEnergy21)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy22, nameof(data.DayEnergy22)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy23, nameof(data.DayEnergy23)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy24, nameof(data.DayEnergy24)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy25, nameof(data.DayEnergy25)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy26, nameof(data.DayEnergy26)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy27, nameof(data.DayEnergy27)));
      series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy28, nameof(data.DayEnergy28)));

      int days = DateTime.DaysInMonth(date.Year, date.Month);
      if (days > 28)
        series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy29, nameof(data.DayEnergy29)));
      if (days > 29)
        series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy30, nameof(data.DayEnergy30)));
      if (days > 30)
        series.Points.Add(CreateDataPointOfDay(date, data.DayEnergy31, nameof(data.DayEnergy31)));
    }

    private async Task LoadStationHistoryOfYear(string stationGuid, DateTime date, bool onlyDataFromService)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      StationAggregationYear? data = await LoadStationAggregationOfYear(stationGuid, date, onlyDataFromService);

      if (data == null)
        return;

      LbHistoryTotal.Text = data.TotalEnergy;

      ChartArea area = ChHistory.ChartAreas.Add("Year");
      area.AxisX.IntervalType = DateTimeIntervalType.Months;
      area.AxisX.Interval = 1;
      area.AxisX.LabelStyle = new LabelStyle() { Format = "MMMM" };

      Series series = ChHistory.Series.Add("Year");
      series.ChartArea = "Year";
      series.SetDefault(true);
      series.XValueType = ChartValueType.Date;
      series.YValueType = ChartValueType.Double;
      series.Enabled = true;
      series.ChartType = SeriesChartType.Column;
      series.BackGradientStyle = GradientStyle.TopBottom;
      series.BorderWidth = 2;
      series.IsXValueIndexed = true;
      series.IsValueShownAsLabel = true;
      series.BorderColor = Color.RoyalBlue;
      series.LabelForeColor = Color.RoyalBlue;
      series.LabelBackColor = Color.White;
      series.LabelBorderColor = Color.RoyalBlue;
      series.ShadowColor = Color.Empty;
      series.MarkerColor = Color.Navy;
      series.MarkerStyle = MarkerStyle.Diamond;
      series.MarkerSize = 10;

      // Echtdaten
      series.Points.Add(CreateDataPointOfMonth(date, data.MonthEnergy1, nameof(data.MonthEnergy1)));
      series.Points.Add(CreateDataPointOfMonth(date, data.MonthEnergy2, nameof(data.MonthEnergy2)));
      series.Points.Add(CreateDataPointOfMonth(date, data.MonthEnergy3, nameof(data.MonthEnergy3)));
      series.Points.Add(CreateDataPointOfMonth(date, data.MonthEnergy4, nameof(data.MonthEnergy4)));
      series.Points.Add(CreateDataPointOfMonth(date, data.MonthEnergy5, nameof(data.MonthEnergy5)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy6, nameof(data.DayEnergy6)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy7, nameof(data.DayEnergy7)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy8, nameof(data.DayEnergy8)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy9, nameof(data.DayEnergy9)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy10, nameof(data.DayEnergy10)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy11, nameof(data.DayEnergy11)));
      series.Points.Add(CreateDataPointOfMonth(date, data.DayEnergy12, nameof(data.DayEnergy12)));
    }

    private DataPoint CreateDataPointOfDay(DateTime dateInMonth, string dayEnergy, string dayEnergyPropertyName)
    {
      var point = new DataPoint();

      Match valueMatch = Regex.Match(dayEnergy, "([.\\d,]+)");
      Match dayNumberMatch = Regex.Match(dayEnergyPropertyName, "([\\d,]+)");

      DateTime dateForValue = new DateTime(dateInMonth.Year, dateInMonth.Month, int.Parse(dayNumberMatch.Value));
      double.TryParse(valueMatch.Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out double value);

      if (dayEnergy.EndsWith("kWh"))
      {
        // do nothing :)
      }
      else if (dayEnergy.EndsWith("Wh") && value > 0)
      {
        // Wh rechnen wir um in kWh, daher durch 100 dividieren
        value = Math.Round(value / 1000, 2);
      }


      point.SetValueXY(dateForValue, value);
      point.ToolTip = string.Format("{0} - {1}", dateForValue.ToShortDateString(), dayEnergy);
      return point;
    }

    private DataPoint CreateDataPointOfMonth(DateTime dateInMonth, string dayEnergy, string dayEnergyPropertyName)
    {
      var point = new DataPoint();

      Match valueMatch = Regex.Match(dayEnergy, "([.\\d,]+)");
      Match dayNumberMatch = Regex.Match(dayEnergyPropertyName, "([\\d,]+)");

      DateTime dateForValue = new DateTime(dateInMonth.Year, int.Parse(dayNumberMatch.Value), 1);
      double.TryParse(valueMatch.Value, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out double value);

      if (dayEnergy.EndsWith("kWh"))
      {
        // do nothing :)
      }
      else if (dayEnergy.EndsWith("Wh") && value > 0)
      {
        // Wh rechnen wir um in kWh, daher durch 100 dividieren
        value = Math.Round(value / 100, 2);
      }


      point.SetValueXY(dateForValue, value);
      point.ToolTip = string.Format("{0} - {1}", dateForValue.ToString("MM"), dayEnergy);
      return point;
    }

    private void AddListBoxLogEntry(string message)
    {
      LbLog.Items.Add($"{DateTime.Now.ToString("HH:mm:ss.fff")} - {message}");
      LbLog.TopIndex = LbLog.Items.Count - 1;
    }

    private async Task LoadStationHistory(bool onlyDataFromService = false)
    {
      if (SelectedStation == null || SelectedHistoryType == null)
        return;

      Station station = SelectedStation;
      DateTime historyDate = DpHistoryDate.Value;
      switch (SelectedHistoryType.Key)
      {
        case "day":
          await LoadStationHistoryOfDay(SelectedStation, DpHistoryDate.Value, onlyDataFromService);
          break;
        case "month":
          await LoadStationHistoryOfMonth(SelectedStation.Guid, DpHistoryDate.Value, onlyDataFromService);
          break;
        case "year":
          await LoadStationHistoryOfYear(SelectedStation.Guid, DpHistoryDate.Value, onlyDataFromService);
          break;
      }
    }

    private async Task<StationAggregationMonth?> LoadStationAggregationOfMonth(string stationGuid, DateTime date, bool onlyDataFromService)
    {
      StationAggregationMonth? result = null;

      if (!onlyDataFromService && AppSettings.History.Enabled && (date.Year < DateTime.Today.Year || date.Month < DateTime.Today.Month))
        // Versuche Daten aus Backup zu laden
        result = HistoryBackup.GetAggregationOfMonth(AppSettings.History.FolderPath, stationGuid, date);

      if (result == null)
      {
        // Versuche Daten von Service zu laden
        AddListBoxLogEntry($"Lade Summen für {date.ToString("MMMM yyyy")}...");
        result = await Task.Run(() => ServiceConnection.GetStationAggregationOfMonth(stationGuid, date.Year, date.Month));
   
        if (result == null)
          AddListBoxLogEntry("Kommunikation T-SUN fehlgeschlagen, bitte erneut versuchen!");
        else if (AppSettings.History.Enabled)
          HistoryBackup.SaveAggregation(AppSettings.History.FolderPath, stationGuid, result);
      }

      return result;
    }

    private async Task<StationAggregationYear?> LoadStationAggregationOfYear(string stationGuid, DateTime date, bool onlyDataFromService)
    {
      StationAggregationYear? result = null;

      if (!onlyDataFromService && AppSettings.History.Enabled && date.Year < DateTime.Today.Year)
        // Versuche Daten aus Backup zu laden
        result = HistoryBackup.GetAggregationOfYear(AppSettings.History.FolderPath, stationGuid, date);

      if (result == null)
      {
        // Versuche Daten von Service zu laden
        AddListBoxLogEntry($"Lade Summen für {date.ToString("yyyy")}...");
        result = await Task.Run(() => ServiceConnection.GetStationAggregationOfYear(stationGuid, date.Year));

        if (result == null)        
          AddListBoxLogEntry("Kommunikation T-SUN fehlgeschlagen, bitte erneut versuchen!");
        else  if (AppSettings.History.Enabled)
          HistoryBackup.SaveAggregation(AppSettings.History.FolderPath, stationGuid, result);
      }

      return result;
    }
  }
}