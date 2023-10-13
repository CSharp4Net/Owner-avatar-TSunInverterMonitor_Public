using NZZ.TSIM.Contracts.Models;
using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
  internal sealed class StationsResponse : BasicResponse
  {
    [JsonPropertyName("total")]
    public int Total { get; set; }
    [JsonPropertyName("rows")]
    public List<Station> Rows { get; set; } = new List<Station>();
  }
}