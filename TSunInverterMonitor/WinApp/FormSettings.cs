using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.WinApp.Models;
using NZZ.TSIM.WinApp.Statics;

namespace NZZ.TSIM.WinApp
{
  public partial class FormSettings : Form
  {
    public FormSettings()
    {
      InitializeComponent();
    }
    public FormSettings(AppSettings appSettings)
        : this()
    {
      AppSettings = appSettings;
    }

    private AppSettings AppSettings { get; init; }

    private void FormSettings_Load(object sender, EventArgs e)
    {
      try
      {
        TbServiceRootUrl.Text = AppSettings.Service.RootUrl;
        TbServiceApiPattern.Text = AppSettings.Service.ApiPattern;

        CkHistoryBackupEnabled.Checked = AppSettings.History.Enabled;
        TbHistoryBackupFolderPath.Text = AppSettings.History.FolderPath;
        TbHistoryBackupFolderPath.ReadOnly = !CkHistoryBackupEnabled.Checked;

        CkAutoLogin.Checked = AppSettings.AutoLoginAfterStart;
        CkAutoMaximize.Checked = AppSettings.AutoMaximizeAfterStart;
        CkAutoSyncService.Checked = AppSettings.AutoSyncAfterLogin;
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void BtnAbort_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
      try
      {
        if (CkHistoryBackupEnabled.Checked && (string.IsNullOrWhiteSpace(TbHistoryBackupFolderPath.Text) || !Directory.Exists(TbHistoryBackupFolderPath.Text)))
        {
          MessageBox.Show("Ist das Datenprotokoll aktiviert, muss ein Verzeichnis ausgewählt sein!", "Validierung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          return;
        }

        AppSettings.Service.RootUrl = TbServiceRootUrl.Text;
        AppSettings.Service.ApiPattern = TbServiceApiPattern.Text;

        AppSettings.History.Enabled = CkHistoryBackupEnabled.Checked;
        AppSettings.History.FolderPath = TbHistoryBackupFolderPath.Text;

        AppSettings.AutoLoginAfterStart = CkAutoLogin.Checked;
        AppSettings.AutoMaximizeAfterStart = CkAutoMaximize.Checked;
        AppSettings.AutoSyncAfterLogin = CkAutoSyncService.Checked;

        ConfigFile.SaveSettings(AppSettings);

        MessageBox.Show("Einstellungen gespeichert.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void CkAggregationLogEnabled_CheckedChanged(object sender, EventArgs e)
    {
      TbHistoryBackupFolderPath.ReadOnly = !CkHistoryBackupEnabled.Checked;
    }

    private void BtnBrowse_Click(object sender, EventArgs e)
    {
      var dialog = new FolderBrowserDialog();
      var dialogResult = dialog.ShowDialog(this);
      if (dialogResult == DialogResult.OK)
        TbHistoryBackupFolderPath.Text = dialog.SelectedPath;
    }
  }
}
