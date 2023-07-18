namespace NZZ.TSIM.WinApp.Internal.Models
{
  internal sealed class HistoryType
  {
    public string Key { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
      return Text;
    }
  }
}
