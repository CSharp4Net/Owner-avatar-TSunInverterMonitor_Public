using NZZ.TSIM.WinApp.Models;
using System.Text;
using System.Text.Json;

namespace NZZ.TSIM.WinApp.Statics
{
  internal static class ConfigFile
  {
    internal static string FilePath => Path.Combine(AppDataPath.RootPath, "AppSettings.json");

    internal static AppSettings LoadSettings()
    {
      if (!File.Exists(FilePath))
        return new AppSettings();

      string fileContent = File.ReadAllText(FilePath, Encoding.UTF8);

      return JsonSerializer.Deserialize<AppSettings>(fileContent)!;
    }

    internal static void SaveSettings(AppSettings settings)
    {
      if (!Directory.Exists(AppDataPath.RootPath))
        Directory.CreateDirectory(AppDataPath.RootPath);

      string fileContent = JsonSerializer.Serialize(settings);

      File.WriteAllText(FilePath, fileContent, Encoding.UTF8);
    }
  }
}