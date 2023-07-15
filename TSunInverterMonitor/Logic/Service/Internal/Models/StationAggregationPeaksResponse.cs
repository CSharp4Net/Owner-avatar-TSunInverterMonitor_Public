using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class StationAggregationPeaksResponse<T> : BasicResponse
    {
        [JsonPropertyName("data")]
        public T? Data { get; set; }
    }
}
