using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class StationAggregationResponse<T> : BasicResponse
    {
        [JsonPropertyName("data")]
        public List<T> Data { get; set; } = new List<T>();
    }
}
