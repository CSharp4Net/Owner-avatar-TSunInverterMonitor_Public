using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
    public class StationAggregationReporterData
    {
        [JsonPropertyName("date")]
        public string Date { get; set; } = "";
        [JsonPropertyName("stationName")]
        public string StationName { get; set; } = "";
        [JsonPropertyName("powerStationGuid")]
        public string PowerStationGuid { get; set; } = "";
        [JsonPropertyName("location")]
        public string Location { get; set; } = "";
    }
}