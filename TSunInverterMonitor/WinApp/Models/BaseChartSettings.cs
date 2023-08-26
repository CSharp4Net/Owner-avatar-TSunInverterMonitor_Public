using System.Windows.Forms.DataVisualization.Charting;

namespace NZZ.TSIM.WinApp.Models
{
  public abstract class BaseChartSettings
  {
    public string SeriesChartTypeName { get; set; } = SeriesChartType.Area.ToString();
  }
}