using Microsoft.VisualBasic;
using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service;
using NZZ.TSIM.WinApp.Internal.Models;
using NZZ.TSIM.WinApp.Statics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NZZ.TSIM.WinApp
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      HistoryTypes = new ObservableCollection<HistoryType>(new List<HistoryType>()
      {
        new HistoryType{ Key = "day", Text = "Tag" },
        new HistoryType{ Key = "month", Text = "Monat" },
        new HistoryType{ Key = "year", Text = "Jahr" }
      });

      InitializeComponent();
    }

    private ServiceSettings ServiceSettings { get; set; }
    private Connection ServiceConnection { get; set; }

    private ObservableCollection<Station>? Stations { get; set; }
    private Station? SelectedStation => (Station)CbStations.SelectedItem;

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

    private void SetMaskByConnectionState()
    {
      if (ServiceConnection.Connected)
      {
        PnHeader.Enabled = false;
        PnBody.Visible = true;

        this.Text = string.Format(Tag.ToString()!, $"Verbunden seit {DateTime.Now:HH:mm}");
      }
      else
      {
        PnHeader.Enabled = true;
        PnBody.Visible = false;

        this.Text = string.Format(Tag.ToString()!, "Nicht verbunden");
      }
    }

    private void SetStationDetails(StationDetails stationDetails)
    {
      LbStationId.Text = stationDetails.Id.ToString();
      LbStationGuid.Text = stationDetails.Guid;
      LbStationAddress.Text = stationDetails.Location;

      LbStationTimeStamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
      LbStationActivePower.Text = stationDetails.ActivePowerNamed;
      LbStationTodayPeakPower.Text = stationDetails.TodayPeakPowerNamed;

      LbStationCurrentDayEnergy.Text = stationDetails.CurrentDayEnergyNamed;
      LbStationCurrentMonthEnergy.Text = stationDetails.CurrentMonthEnergyNamed;
      LbStationCurrentYearEnergy.Text = stationDetails.CurrentYearEnergyNamed;
      LbStationTotalEnergy.Text = stationDetails.TotalEnergyNamed;

      CbHistoryType.DataSource = HistoryTypes;
    }

    private async Task LoadStationHistoryOfDay(Station station, DateTime date)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      StationAggregationDay? data = null;

      if (ServiceSettings.HistoryBackup.Enabled && date < DateTime.Today)
        // Versuche Daten aus Backup zu laden
        data = HistoryBackup.GetAggregationOfDay(ServiceSettings.HistoryBackup.FolderPath, station.Guid, date);

      if (data == null)
      {
        // Versuche Daten von Service zu laden
        AddListBoxLogEntry($"Load history for day '{date.ToString("yyyy-MM-dd")}'...");
        data = await Task.Run(() => ServiceConnection.GetStationAggregationOfDay(station, date));
      }

      if (data == null)
      {
        AddListBoxLogEntry($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, station.Guid, data);

      ChartArea area = ChHistory.ChartAreas.Add("Default");
      area.AxisX.IntervalType = DateTimeIntervalType.Minutes;
      area.AxisX.Interval = 1;
      area.AxisY.Maximum = 600D;

      Series series = ChHistory.Series.Add("Default");
      series.ChartArea = "Default";
      series.SetDefault(true);
      series.XValueType = ChartValueType.Time;
      series.YValueType = ChartValueType.Double;
      series.Enabled = true;
      series.ChartType = SeriesChartType.Area;
      series.BackGradientStyle = GradientStyle.TopBottom;
      series.BorderWidth = 2;
      series.IsXValueIndexed = true;
      series.IsValueShownAsLabel = true;
      series.BorderColor = Color.RoyalBlue;
      series.LabelForeColor = Color.RoyalBlue;
      series.ShadowColor = Color.Empty;
      series.MarkerColor = Color.Navy;
      series.MarkerStyle = MarkerStyle.Diamond;

      // Echtdaten
      foreach (var item in data.Peaks.ChartEntries)
      {
        var point = new DataPoint();
        point.SetValueXY(item.PointOfTime, Math.Round(item.PeakPower));
        point.ToolTip = string.Format("{0} - {1}W", item.PointOfTime.ToShortTimeString(), Math.Round(item.PeakPower));
        series.Points.Add(point);
      }
    }

    private async Task LoadStationHistoryOfMonth(string stationGuid, DateTime date)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      AddListBoxLogEntry($"Load history for month '{date.ToString("yyyy-MM")}'...");
      StationAggregationMonth? data = await Task.Run(() => ServiceConnection.GetStationAggregationOfMonth(stationGuid, date.Year, date.Month));

      if (data == null)
      {
        AddListBoxLogEntry($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, stationGuid, data);
    }

    private async Task LoadStationHistoryOfYear(string stationGuid, DateTime date)
    {
      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      AddListBoxLogEntry($"Load history for year '{date.ToString("yyyy")}'...");
      StationAggregationYear? data = await Task.Run(() => ServiceConnection.GetStationAggregationOfYear(stationGuid, date.Year));

      if (data == null)
      {
        AddListBoxLogEntry($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, stationGuid, data);
    }

    private void AddListBoxLogEntry(string message)
    {
      LbLog.Items.Add($"{DateTime.Now.ToString("HH:mm:ss.fff")} - {message}");
      LbLog.TopIndex = LbLog.Items.Count - 1;
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      try
      {
        if (!Directory.Exists(AppDataPath.LogFolderPath))
          Directory.CreateDirectory(AppDataPath.LogFolderPath);

        ServiceSettings = ConfigFile.LoadSettings();
        ServiceConnection = new Connection(ServiceSettings, AppDataPath.LogFolderPath);

        TbServiceUserName.Text = Properties.Settings.Default.LastUserName;

        if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastPassword))
          TbServicePassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Properties.Settings.Default.LastPassword));
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void BtnOpenSettings_Click(object sender, EventArgs e)
    {
      new FormSettings(ServiceSettings).ShowDialog(this);
      ServiceConnection.Reset(ServiceSettings);
    }

    private async void BtnConnect_Click(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        Properties.Settings.Default.LastUserName = TbServiceUserName.Text;
        Properties.Settings.Default.LastPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TbServicePassword.Text));
        Properties.Settings.Default.Save();

        var credentials = new LoginCredentials
        {
          UserName = TbServiceUserName.Text,
          Password = TbServicePassword.Text
        };

        AddListBoxLogEntry($"Connecting as {credentials.UserName}...");
        LoginResult loginResult = await Task.Run(() => ServiceConnection.Login(credentials));

        SetMaskByConnectionState();

        if (!loginResult.Successful)
        {
          AddListBoxLogEntry($"Connecting failed: {loginResult.ErrorMessage}");
          MessageBox.Show(loginResult.ErrorMessage, "Fehlermeldung von T-SUN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        AddListBoxLogEntry("Connecting established, get stations...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          AddListBoxLogEntry($"Get stations failed, please try again with [Refresh]!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        AddListBoxLogEntry($"{Stations.Count} station(s) found!");
        CbStations.DataSource = Stations;

        if (ServiceSettings.HistoryBackup.Enabled)
          HistoryBackup.SaveStationList(ServiceSettings.HistoryBackup.FolderPath, stations);
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

    private async void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        if (ServiceConnection.Connected)
        {
          AddListBoxLogEntry($"Disconnecting...");
          await ServiceConnection.Logout();
        }
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private async void BtnRefresh_Click(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        AddListBoxLogEntry("Get stations...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          AddListBoxLogEntry($"Communication with T-SUN failed, please try again!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        AddListBoxLogEntry($"{Stations.Count} station(s) found!");
        CbStations.DataSource = Stations;
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

    private async void BtnDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        AddListBoxLogEntry($"Disconnecting...");
        await ServiceConnection.Logout();
        SetMaskByConnectionState();
        return;
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private async void CbStations_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (SelectedStation == null)
          return;

        IsBusy = true;

        Station station = SelectedStation;
        AddListBoxLogEntry($"Load details of station '{station.Name}'...");
        StationDetails? stationDetails = await Task.Run(() => ServiceConnection.GetStationDetails(station.Id));

        if (stationDetails == null)
        {
          AddListBoxLogEntry($"Communication with T-SUN failed, please try again!");
          return;
        }

        station.TimeZone = stationDetails.TimeZone;
        station.TimeZoneOffset = stationDetails.TimeZoneOffset;

        AddListBoxLogEntry($"Details of station {station.Id} loaded!");
        SetStationDetails(stationDetails);

        if (ServiceSettings.HistoryBackup.Enabled)
          HistoryBackup.SaveStationDetails(ServiceSettings.HistoryBackup.FolderPath, stationDetails);
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

    private async void HistoryControl_ValueChanged(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        if (SelectedStation == null || SelectedHistoryType == null)
          return;

        Station station = SelectedStation;
        DateTime historyDate = DpHistoryDate.Value;
        switch (SelectedHistoryType.Key)
        {
          case "day":
            await LoadStationHistoryOfDay(SelectedStation, DpHistoryDate.Value);
            break;
          case "month":
            await LoadStationHistoryOfMonth(SelectedStation.Guid, DpHistoryDate.Value);
            break;
          case "year":
            await LoadStationHistoryOfYear(SelectedStation.Guid, DpHistoryDate.Value);
            break;
        }
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

    private void BtnDebug_Click(object sender, EventArgs e)
    {
      PnBody.Visible = true;

      string fileContent = File.ReadAllText("F:\\Projects\\VS\\TSunInverterMonitor_Private\\TSunInverterMonitor\\Documentation\\T-SUN Day aggregation.txt");
      var peaksData = JsonSerializer.Deserialize<StationAggregationDayPeaks>(fileContent);

      ChHistory.ChartAreas.Clear();
      ChHistory.Series.Clear();

      ChartArea area = ChHistory.ChartAreas.Add("Default");
      area.AxisX.IntervalType = DateTimeIntervalType.Minutes;
      area.AxisX.Interval = 1;
      area.AxisY.Maximum = 600D;

      Series series = ChHistory.Series.Add("Default");
      series.ChartArea = "Default";
      series.SetDefault(true);
      series.XValueType = ChartValueType.Time;
      series.YValueType = ChartValueType.Double;
      series.Enabled = true;
      series.ChartType = SeriesChartType.Area;
      series.BackGradientStyle = GradientStyle.TopBottom;
      series.BorderWidth = 2;
      series.IsXValueIndexed = true;
      series.IsValueShownAsLabel = true;
      series.BorderColor = Color.RoyalBlue;
      series.LabelForeColor = Color.RoyalBlue;
      series.ShadowColor = Color.Empty;
      series.MarkerColor = Color.Navy;
      series.MarkerStyle = MarkerStyle.Diamond;

      // Künstlicher Start bei 0
      var point = new DataPoint();
      point.SetValueXY(peaksData.ChartEntries.First().PointOfTime.AddMinutes(-15), 0);
      series.Points.Add(point);

      // Echtdaten
      foreach (var item in peaksData.ChartEntries)
      {
        point = new DataPoint();
        point.SetValueXY(item.PointOfTime, Math.Round(item.PeakPower));
        point.ToolTip = string.Format("{0} - {1}W", item.PointOfTime.ToShortTimeString(), Math.Round(item.PeakPower));
        series.Points.Add(point);
      }

      // Künstliches Ende bei 0
      point = new DataPoint();
      point.SetValueXY(peaksData.ChartEntries.Last().PointOfTime.AddMinutes(15), 0);
      series.Points.Add(point);
    }

    private void BtnDayBefore_Click(object sender, EventArgs e)
    {
      DpHistoryDate.Value = DpHistoryDate.Value.AddDays(-1);
    }

    private void BtnDayAfter_Click(object sender, EventArgs e)
    {
      DpHistoryDate.Value = DpHistoryDate.Value.AddDays(1);
    }
  }
}