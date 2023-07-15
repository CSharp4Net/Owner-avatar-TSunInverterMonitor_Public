using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
  public sealed class StationAggregationDay : StationAggregationReporterData
  {
    [JsonPropertyName("dayEnergy")]
    public string TotalEnergy { get; set; } = "";

    public StationAggregationDayPeaks Peaks { get; set; } = new StationAggregationDayPeaks();
  }
}