using System.Runtime.CompilerServices;

namespace NZZ.TSIM.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }

        internal static void HandleException(Exception ex, [CallerMemberName] string sender = "")
        {
            MessageBox.Show(ex.ToString(), $"Ausnahme in {sender}", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}