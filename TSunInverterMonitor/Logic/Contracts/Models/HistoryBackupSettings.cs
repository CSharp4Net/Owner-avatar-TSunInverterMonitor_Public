namespace NZZ.TSIM.Contracts.Models
{
  public sealed class HistoryBackupSettings
  {
    public bool Enabled { get; set; }
    public string FolderPath { get; set; } = "";
  }
}