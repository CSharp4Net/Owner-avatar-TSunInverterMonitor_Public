using NZZ.TSIM.Contracts.Models;

namespace NZZ.TSIM.WinApp.Models
{
  public sealed class AppSettings
  {
    public bool AutoLoginAfterStart { get; set; }
    public bool AutoMaximizeAfterStart { get; set; }
    public bool AutoSyncAfterLogin { get; set; }

    public ServiceSettings Service { get; set; } = new ServiceSettings();
    public HistorySettings History { get; set; } = new HistorySettings();
    public ChartSettings Charts { get; set; } = new ChartSettings();
  }
}