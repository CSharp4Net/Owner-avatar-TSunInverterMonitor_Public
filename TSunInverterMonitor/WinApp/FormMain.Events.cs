using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service;
using NZZ.TSIM.WinApp.Statics;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace NZZ.TSIM.WinApp
{
  partial class FormMain
  {
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

    private void BtnOpenSettings_Click(object sender, EventArgs e)
    {
      new FormSettings(AppSettings).ShowDialog(this);
      ServiceConnection.Reset(AppSettings.Service);
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

        AddListBoxLogEntry($"Verbinde zu T-SUN als {credentials.UserName}...");
        LoginResult loginResult = await Task.Run(() => ServiceConnection.Login(credentials));

        SetMaskByConnectionState();

        if (!loginResult.Successful)
        {
          AddListBoxLogEntry($"Verbindung konnte nicht hergestellt werden: {loginResult.ErrorMessage}");
          MessageBox.Show(loginResult.ErrorMessage, "Fehlermeldung von T-SUN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        AddListBoxLogEntry("Verbindung hergestellt, rufe Stationen ab...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          AddListBoxLogEntry("Abrufen der Stationen fehlgeschlagen, bitte erneut versuchen!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        CbStations.DataSource = Stations;

        if (AppSettings.History.Enabled)
          HistoryBackup.SaveStationList(AppSettings.History.FolderPath, stations);
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
          AddListBoxLogEntry("Verbindung zu T-SUN wird getrennt...");
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

        AddListBoxLogEntry("Rufe Stationen ab...");
        List<Station>? stations = await Task.Run(() => ServiceConnection.GetStations());

        if (stations == null)
        {
          AddListBoxLogEntry("Kommunikation T-SUN fehlgeschlagen, bitte erneut versuchen!");
          return;
        }

        Stations = new ObservableCollection<Station>(stations);
        AddListBoxLogEntry($"Es wurden {Stations.Count} Stationen gefunden.");
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
        AddListBoxLogEntry("Verbindung zu T-SUN wird getrennt...");
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
        AddListBoxLogEntry($"Lade Informationen zur Station '{station.Name}'...");
        DetailsOfSelectedStation = await Task.Run(() => ServiceConnection.GetStationDetails(station.Id));

        if (DetailsOfSelectedStation == null)
        {
          AddListBoxLogEntry("Kommunikation T-SUN fehlgeschlagen, bitte erneut versuchen!");
          return;
        }

        station.TimeZone = DetailsOfSelectedStation.TimeZone;
        station.TimeZoneOffset = DetailsOfSelectedStation.TimeZoneOffset;

        SetStationDetails(DetailsOfSelectedStation);

        if (AppSettings.History.Enabled)
          HistoryBackup.SaveStationDetails(AppSettings.History.FolderPath, DetailsOfSelectedStation);
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

    private void BtnOpenWorkFolder_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start("explorer.exe", AppDataPath.RootPath);
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void CbHistoryType_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        if (SelectedHistoryType!.Key == "day")
          DpHistoryDate.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        else if (SelectedHistoryType!.Key == "month")
          DpHistoryDate.CustomFormat = "yyyy MMMM";
        else
          DpHistoryDate.CustomFormat = "yyyy";

        LoadStationHistory();
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

    private void DpHistoryDate_ValueChanged(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        LoadStationHistory();
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

    private void BtnDayBefore_Click(object sender, EventArgs e)
    {
      if (SelectedHistoryType!.Key == "day")
        DpHistoryDate.Value = DpHistoryDate.Value.AddDays(-1);
      else if (SelectedHistoryType!.Key == "month")
        DpHistoryDate.Value = DpHistoryDate.Value.AddMonths(-1);
      else
        DpHistoryDate.Value = DpHistoryDate.Value.AddYears(-1);
    }

    private void BtnDayAfter_Click(object sender, EventArgs e)
    {
      if (SelectedHistoryType!.Key == "day")
        DpHistoryDate.Value = DpHistoryDate.Value.AddDays(1);
      else if (SelectedHistoryType!.Key == "month")
        DpHistoryDate.Value = DpHistoryDate.Value.AddMonths(1);
      else
        DpHistoryDate.Value = DpHistoryDate.Value.AddYears(1);
    }

    private void BtnReloadHistory_Click(object sender, EventArgs e)
    {
      try
      {
        IsBusy = true;

        LoadStationHistory(true);
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

    private void BtnOpenHistoryFolder_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start("explorer.exe", AppSettings.History.FolderPath);
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void TmAutoSync_Tick(object sender, EventArgs e)
    {
      BtnRefresh_Click(sender, e);

      if (DpHistoryDate.Value >= DateTime.Today)
        BtnReloadHistory_Click(sender, e);
    }
  }
}