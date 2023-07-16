using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.WinApp.Statics;

namespace NZZ.TSIM.WinApp
{
  public partial class FormSettings : Form
  {
    public FormSettings()
    {
      InitializeComponent();
    }
    public FormSettings(ServiceSettings serviceSettings)
        : this()
    {
      ServiceSettings = serviceSettings;
    }

    private ServiceSettings ServiceSettings { get; init; }

    private void FormSettings_Load(object sender, EventArgs e)
    {
      try
      {
        TbServiceRootUrl.Text = ServiceSettings.RootUrl;
        TbServiceApiPattern.Text = ServiceSettings.ApiPattern;

        CkHistoryBackupEnabled.Checked = ServiceSettings.HistoryBackup.Enabled;
        TbHistoryBackupFolderPath.Text = ServiceSettings.HistoryBackup.FolderPath;
        TbHistoryBackupFolderPath.ReadOnly = !CkHistoryBackupEnabled.Checked;
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

        ServiceSettings.RootUrl = TbServiceRootUrl.Text;
        ServiceSettings.ApiPattern = TbServiceApiPattern.Text;

        ServiceSettings.HistoryBackup.Enabled = CkHistoryBackupEnabled.Checked;
        ServiceSettings.HistoryBackup.FolderPath = TbHistoryBackupFolderPath.Text;

        ConfigFile.SaveSettings(ServiceSettings);
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
