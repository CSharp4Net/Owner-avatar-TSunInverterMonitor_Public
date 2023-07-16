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
      //LbLog.Items.Add($"Clear history...");
      //Series series = ChHistory.Series[0];
      //series.Points.Clear();

      LbLog.Items.Add($"Load history for day '{date.ToString("yyyy-MM-dd")}'...");
      StationAggregationDay? data = await Task.Run(() => ServiceConnection.GetStationAggregationOfDay(station, date));

      if (data == null)
      {
        LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, station.Guid, data);
    }

    private async Task LoadStationHistoryOfMonth(string stationGuid, DateTime date)
    {
      //LbLog.Items.Add($"Clear history...");
      //Series series = ChHistory.Series[0];
      //series.Points.Clear();

      LbLog.Items.Add($"Load history for month '{date.ToString("yyyy-MM")}'...");
      StationAggregationMonth? data = await Task.Run(() => ServiceConnection.GetStationAggregationOfMonth(stationGuid, date.Year, date.Month));

      if (data == null)
      {
        LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, stationGuid, data);
    }

    private async Task LoadStationHistoryOfYear(string stationGuid, DateTime date)
    {
      //LbLog.Items.Add($"Clear history...");
      //Series series = ChHistory.Series[0];
      //series.Points.Clear();

      LbLog.Items.Add($"Load history for year '{date.ToString("yyyy")}'...");
      StationAggregationYear? data = await Task.Run(() => ServiceConnection.GetStationAggregationOfYear(stationGuid, date.Year));

      if (data == null)
      {
        LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
        return;
      }

      LbHistoryTotal.Text = data.TotalEnergy;

      if (ServiceSettings.HistoryBackup.Enabled)
        HistoryBackup.SaveAggregation(ServiceSettings.HistoryBackup.FolderPath, stationGuid, data);
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

        LbLog.Items.Add($"Connecting as {credentials.UserName}...");
        LoginResult loginResult = await Task.Run(() => ServiceConnection.Login(credentials));

        SetMaskByConnectionState();

        if (!loginResult.Successful)
        {
          LbLog.Items.Add($"Connecting failed: {loginResult.ErrorMessage}");
          MessageBox.Show(loginResult.ErrorMessage, "Fehlermeldung von T-SUN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        LbLog.Items.Add("Connecting established, get stations...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          LbLog.Items.Add($"Get stations failed, please try again with [Refresh]!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        LbLog.Items.Add($"{Stations.Count} station(s) found!");
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
          LbLog.Items.Add($"Disconnecting...");
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

        LbLog.Items.Add("Get stations...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        LbLog.Items.Add($"{Stations.Count} station(s) found!");
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
        LbLog.Items.Add($"Disconnecting...");
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
        LbLog.Items.Add($"Load details of station '{station.Name}'...");
        StationDetails? stationDetails = await Task.Run(() => ServiceConnection.GetStationDetails(station.Id));

        if (stationDetails == null)
        {
          LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
          return;
        }

        station.TimeZone = stationDetails.TimeZone;
        station.TimeZoneOffset = stationDetails.TimeZoneOffset;

        LbLog.Items.Add($"Details of station {station.Id} loaded!");
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

      Axis axis = area.AxisX;
      //axis.IntervalType = DateTimeIntervalType.Minutes;
      //axis.Interval = 1;
      axis.Title = "Zeit";
      axis.TitleFont = new Font("Arial", 16);

      axis = area.AxisY;
      axis.Title = "Watt";
      axis.TitleFont = new Font("Arial", 16);
      //axis.TitleAlignment = StringAlignment.Far;

      Series series = ChHistory.Series.Add("Default");
      series.SetDefault(true);
      series.Enabled = true;
      series.ChartType = SeriesChartType.Area;
      //series.Label = "Hallo Welt";

      series.Points.Clear();

      // Künstlicher Start bei 0
      var point = new DataPoint { LegendText = "05:00" };
      point.SetValueXY(new DateTime(2023, 07, 12, 5, 0, 0), 0);
      series.Points.Add(point);
      // Echtdaten
      point = new DataPoint { AxisLabel = "05:15" };
      point.SetValueXY(new DateTime(2023, 07, 12, 5, 15, 0), 35);
      series.Points.Add(point);
      point = new DataPoint { AxisLabel = "05:30" };
      point.SetValueXY(new DateTime(2023, 07, 12, 5, 30, 0), 55);
      series.Points.Add(point);
      point = new DataPoint { AxisLabel = "05:45" };
      point.SetValueXY(new DateTime(2023, 07, 12, 5, 45, 0), 125);
      series.Points.Add(point);
      point = new DataPoint { AxisLabel = "06:00" };
      point.SetValueXY(new DateTime(2023, 07, 12, 6, 0, 0), 250);
      series.Points.Add(point);
      // Künstliches Ende bei 0
      point = new DataPoint { AxisLabel = "06:15" };
      point.SetValueXY(new DateTime(2023, 07, 12, 6, 15, 0), 0);
      series.Points.Add(point);

      //series.XValueType = ChartValueType.Time;
      //foreach (var item in peaksData.ChartEntries)
      //{
      //  var point = new DataPoint();
      //  //if (counter % 60 == 0)
      //  //{
      //  point.AxisLabel = item.PointOfTime.ToString(@"hh\:mm");
      //  point.SetValueXY(item.PointOfTime, item.PeakPower); // item.PointOfTime.Hour * 60 + item.PointOfTime.Minute;
      //  //point.SetValueY(item.PeakPower);
      //  //}
      //  //else
      //  //{
      //  //  point.AxisLabel = String.Empty;
      //  //}
      //  series.Points.Add(point);
      //}
    }
  }
}