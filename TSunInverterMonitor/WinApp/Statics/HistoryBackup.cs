using NZZ.TSIM.Contracts.Models;
using System.Text;
using System.Text.Json;

namespace NZZ.TSIM.WinApp.Statics
{
  internal static class HistoryBackup
  {
    internal static void SaveStationList(string folderPath, IEnumerable<Station> stations)
    {
      string fileContent = JsonSerializer.Serialize(stations);
      string filePath = Path.Combine(folderPath, "Stations.json");

      if (!Directory.Exists(folderPath))
        Directory.CreateDirectory(folderPath);

      File.WriteAllText(filePath, fileContent, Encoding.UTF8);
    }

    internal static void SaveStationDetails(string folderPath, StationDetails station)
    {
      string fileContent = JsonSerializer.Serialize(station);
      string stationFolderPath = Path.Combine(folderPath, station.Guid);

      if (!Directory.Exists(stationFolderPath))
        Directory.CreateDirectory(stationFolderPath);

      File.WriteAllText(Path.Combine(stationFolderPath, $"{station.Id}.json"), fileContent, Encoding.UTF8);
    }

    internal static void SaveAggregation<T>(string folderPath, string stationGuid, T aggregationData) where T : StationAggregationReporterData
    {
      string fileContent = JsonSerializer.Serialize(aggregationData);
      string stationFolderPath = Path.Combine(folderPath, stationGuid);

      if (!Directory.Exists(stationFolderPath))
        Directory.CreateDirectory(stationFolderPath);

      File.WriteAllText(Path.Combine(stationFolderPath, $"{aggregationData.Date}.json"), fileContent, Encoding.UTF8);
    }

    internal static StationAggregationDay? GetAggregationOfDay(string folderPath, string stationGuid, DateTime date)
    {
      string stationFolderPath = Path.Combine(folderPath, stationGuid);
      if (!Directory.Exists(stationFolderPath))
        return default;

      string filePath = Path.Combine(stationFolderPath, $"{date.ToString("yyyy-MM-dd")}.json");
      if (!File.Exists(filePath))
        return default;

      string fileContent = File.ReadAllText(filePath, Encoding.UTF8);

      return JsonSerializer.Deserialize<StationAggregationDay>(fileContent);
    }

    internal static StationAggregationMonth? GetAggregationOfMonth(string folderPath, string stationGuid, DateTime date)
    {
      string stationFolderPath = Path.Combine(folderPath, stationGuid);
      if (!Directory.Exists(stationFolderPath))
        return default;

      string filePath = Path.Combine(stationFolderPath, $"{date.ToString("yyyy-MM")}.json");
      if (!File.Exists(filePath))
        return default;

      string fileContent = File.ReadAllText(filePath, Encoding.UTF8);

      return JsonSerializer.Deserialize<StationAggregationMonth>(fileContent);
    }

    internal static StationAggregationYear? GetAggregationOfYear(string folderPath, string stationGuid, DateTime date)
    {
      string stationFolderPath = Path.Combine(folderPath, stationGuid);
      if (!Directory.Exists(stationFolderPath))
        return default;

      string filePath = Path.Combine(stationFolderPath, $"{date.ToString("yyyy")}.json");
      if (!File.Exists(filePath))
        return default;

      string fileContent = File.ReadAllText(filePath, Encoding.UTF8);

      return JsonSerializer.Deserialize<StationAggregationYear>(fileContent);
    }
  }
}