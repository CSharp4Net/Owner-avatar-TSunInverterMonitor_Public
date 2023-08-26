namespace NZZ.TSIM.WinApp.Models
{
  public sealed class ChartOfDaySettings : BaseChartSettings
  {
    public TimeSpan VisibleAreaBegin { get; set; } = new TimeSpan(6, 0, 0);
    public TimeSpan VisibleAreaEnd { get; set; } = new TimeSpan(22, 0, 0);
  }
}