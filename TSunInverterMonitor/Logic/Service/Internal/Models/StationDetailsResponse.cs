using NZZ.TSIM.Contracts.Models;
using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class StationDetailsResponse : BasicResponse
    {
        [JsonPropertyName("data")]
        public StationDetails Details { get; set; } = new StationDetails();
    }
}