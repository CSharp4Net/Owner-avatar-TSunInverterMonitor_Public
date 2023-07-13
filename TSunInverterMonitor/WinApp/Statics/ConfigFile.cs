using NZZ.TSIM.Contracts.Models;
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

            string fileContent = File.ReadAllText(FilePath);

            return JsonSerializer.Deserialize<ServiceSettings>(fileContent)!;
        }
    }
}