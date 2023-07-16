using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
  public class Station
  {
    [JsonPropertyName("powerStationId")]
    public int Id { get; set; }
    [JsonPropertyName("locationLatitude")]
    public double Latitude { get; set; }
    [JsonPropertyName("locationLongitude")]
    public double Longitude { get; set; }
    [JsonPropertyName("stationName")]
    public string Name { get; set; } = "";
    [JsonPropertyName("powerStationGuid")]
    public string Guid { get; set; } = "";
    [JsonPropertyName("status")]
    public string Status { get; set; } = "";

    /// <summary>
    /// Zeitzone
    /// Achtung: Wird nicht durch JSON-Serialisierung gesetzt, sondern sobald die Details einer Station abgerufen werden.
    /// </summary>
    public string TimeZone { get; set; } = "";
    public string TimeZoneOffset { get; set; } = "";

    public override string ToString()
    {
      return $"{Name} ({Status})";
    }
  }
}