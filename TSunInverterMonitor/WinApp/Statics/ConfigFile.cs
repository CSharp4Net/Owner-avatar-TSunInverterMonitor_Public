using NZZ.TSIM.Contracts.Models;
using System.Text;
using System.Text.Json;

namespace NZZ.TSIM.WinApp.Statics
{
  internal static class ConfigFile
  {
    internal static string FilePath => Path.Combine(AppDataPath.RootPath, "ServiceSettings.json");

    internal static ServiceSettings LoadSettings()
    {
      if (!File.Exists(FilePath))
        return new ServiceSettings();

      string fileContent = File.ReadAllText(FilePath, Encoding.UTF8);

      return JsonSerializer.Deserialize<ServiceSettings>(fileContent)!;
    }

    internal static void SaveSettings(ServiceSettings settings)
    {
      if (!Directory.Exists(AppDataPath.RootPath))
        Directory.CreateDirectory(AppDataPath.RootPath);

      string fileContent = JsonSerializer.Serialize(settings);

      File.WriteAllText(FilePath, fileContent, Encoding.UTF8);
    }
  }
}