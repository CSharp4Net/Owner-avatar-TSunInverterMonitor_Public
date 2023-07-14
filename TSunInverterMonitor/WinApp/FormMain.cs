using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service;
using NZZ.TSIM.WinApp.Statics;
using System.Collections.ObjectModel;
using System.Text;

namespace NZZ.TSIM.WinApp
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private ServiceSettings ServiceSettings { get; set; }
    private Connection ServiceConnection { get; set; } = new Connection();
    private ObservableCollection<Station>? Stations { get; set; }

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

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      try
      {
        TbServiceUserName.Text = Properties.Settings.Default.LastUserName;

        if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.LastPassword))
          TbServicePassword.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Properties.Settings.Default.LastPassword));

        ServiceSettings = ConfigFile.LoadSettings();
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void BtnOpenSettings_Click(object sender, EventArgs e)
    {
      new FormSettings(ServiceSettings).ShowDialog(this);
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
  }
}