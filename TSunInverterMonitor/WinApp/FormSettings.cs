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

        CkAggregationLogEnabled.Checked = ServiceSettings.AggregationDataLogSettings.Enabled;
        TbAggregationLogFolderPath.Text = ServiceSettings.AggregationDataLogSettings.FolderPath;
        TbAggregationLogFolderPath.ReadOnly = !CkAggregationLogEnabled.Checked;
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
        ServiceSettings.RootUrl = TbServiceRootUrl.Text;
        ServiceSettings.ApiPattern = TbServiceApiPattern.Text;

        ServiceSettings.AggregationDataLogSettings.Enabled = CkAggregationLogEnabled.Checked;
        ServiceSettings.AggregationDataLogSettings.FolderPath = TbAggregationLogFolderPath.Text;

        ConfigFile.SaveSettings(ServiceSettings);
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void CkAggregationLogEnabled_CheckedChanged(object sender, EventArgs e)
    {
      TbAggregationLogFolderPath.ReadOnly = !CkAggregationLogEnabled.Checked;
    }

    private void BtnBrowse_Click(object sender, EventArgs e)
    {
      var dialog = new FolderBrowserDialog();
      var dialogResult = dialog.ShowDialog(this);
      if (dialogResult == DialogResult.OK)
        TbAggregationLogFolderPath.Text = dialog.SelectedPath;
    }
  }
}
