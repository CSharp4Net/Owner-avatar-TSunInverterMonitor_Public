using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
    public class StationAggregationReporterData
    {
        [JsonPropertyName("date")]
        public string date { get; set; } = "";
        [JsonPropertyName("stationName")]
        public string stationName { get; set; } = "";
        [JsonPropertyName("powerStationGuid")]
        public string powerStationGuid { get; set; } = "";
        [JsonPropertyName("location")]
        public string location { get; set; } = "";
    }
}