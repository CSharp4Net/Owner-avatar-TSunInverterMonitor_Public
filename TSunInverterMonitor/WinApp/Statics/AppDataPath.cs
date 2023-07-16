using NZZ.TSIM.Contracts;

namespace NZZ.TSIM.WinApp.Statics
{
  internal static class AppDataPath
  {
    internal static string RootPath => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        Constants.Autor,
        Constants.ProductName);

    internal static string LogFolderPath
      => Path.Combine(RootPath, "Log");
  }
}