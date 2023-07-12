using NZZ.TSIM.Contracts.Models;
using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Models
{
    internal sealed class StationsResponse : BasicResponse
    {
        [JsonPropertyName("data")]
        public List<Station> Stations { get; set; } = new List<Station>();
    }
}