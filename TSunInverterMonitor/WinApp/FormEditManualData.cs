using NZZ.TSIM.Contracts.Models;

namespace NZZ.TSIM.WinApp
{
  public partial class FormEditManualData : Form
  {
    public FormEditManualData()
    {
      InitializeComponent();
    }

    private StationAggregationReporterData aggregationData;

    internal void SetData<T>(T aggregationData) where T : StationAggregationReporterData
    {
      this.aggregationData = aggregationData;

      GridData.DataSource = this.aggregationData;
    }

    private void BtnAbort_Click(object sender, EventArgs e)
    {
      try
      {
        this.Close();
      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
      try
      {

      }
      catch (Exception ex)
      {
        Program.HandleException(ex);
      }
    }
  }
}
