using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service;
using NZZ.TSIM.WinApp.Internal.Models;
using NZZ.TSIM.WinApp.Statics;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
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

    private void SetStationDetails(StationDetails details)
    {
      LbStationId.Text = details.Id.ToString();
      LbStationGuid.Text = details.Guid;
      LbStationAddress.Text = details.Location;

      LbStationTimeStamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
      LbStationActivePower.Text = details.ActivePowerNamed;
      LbStationTodayPeakPower.Text = details.TodayPeakPowerNamed;

      LbStationCurrentDayEnergy.Text = details.CurrentDayEnergyNamed;
      LbStationCurrentMonthEnergy.Text = details.CurrentMonthEnergyNamed;
      LbStationCurrentYearEnergy.Text = details.CurrentYearEnergyNamed;
      LbStationTotalEnergy.Text = details.TotalEnergyNamed;

      CbHistoryType.DataSource = HistoryTypes;
    }

    private async Task LoadStationHistoryOfDay(string stationGuid, DateTime date)
    {
      LbLog.Items.Add($"Clear history...");
      Series series = ChHistory.Series[0];
      series.Points.Clear();

      LbLog.Items.Add($"Load history for day '{date.ToString("yyyy-MM-dd")}' ...");
      StationAggregationDay? aggregationDay = await Task.Run(() => ServiceConnection.GetStationAggregationOfDay(stationGuid, date));

      if (aggregationDay == null)
      {
        LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
        return;
      }

      // TODO
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      try
      {
        ServiceSettings = ConfigFile.LoadSettings();
        ServiceConnection = new Connection(ServiceSettings);

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
        StationDetails? details = await Task.Run(() => ServiceConnection.GetStationDetails(station.Id));

        if (details == null)
        {
          LbLog.Items.Add($"Communication with T-SUN failed, please try again!");
          return;
        }

        LbLog.Items.Add($"Details of station {station.Id} loaded!");
        SetStationDetails(details);
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
            //await LoadStationHistoryOfDay(SelectedStation.Guid, DpHistoryDate.Value);
            break;
          case "month":
            //await LoadStationHistoryOfMonth(SelectedStation.Guid, DpHistoryDate.Value);
            break;
          case "year":
            //await LoadStationHistoryOfYear(SelectedStation.Guid, DpHistoryDate.Value);
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
  }
}