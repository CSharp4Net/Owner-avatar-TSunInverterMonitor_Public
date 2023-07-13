using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class StationAggregationPayload
    {
        [JsonPropertyName("businessType")]
        public string BusinessType { get; set; } = "";
        [JsonPropertyName("powerStationGuids")]
        public string PowerStationGuids { get; set; } = "";
        [JsonPropertyName("mode")]
        public string Mode { get; set; } = "";
        [JsonPropertyName("date")]
        public string Date { get; set; } = "";
    }
}
