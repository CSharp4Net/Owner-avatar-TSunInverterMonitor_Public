using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace NZZ.TSIM.WinApp
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMain());
    }

    internal static void HandleException(Exception ex, [CallerMemberName] string sender = "")
    {
      MessageBox.Show(ex.ToString(), $"Ausnahme in {sender}", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}