using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
  public sealed class StationAggregationDayPeaks : StationAggregationReporterData
  {
    [JsonPropertyName("dimensions")]
    public List<string> Dimensions { get; set; } = new List<string>();

    [JsonPropertyName("chart")]
    public List<ChartEntry> ChartEntries { get; set; } = new List<ChartEntry>();
  }

  public sealed class ChartEntry
  {
    [JsonPropertyName("date")]
    public DateTime PointOfTime { get; set; }
    [JsonPropertyName("totalPeakPower")]
    public double PeakPower { get; set; }
  }
}