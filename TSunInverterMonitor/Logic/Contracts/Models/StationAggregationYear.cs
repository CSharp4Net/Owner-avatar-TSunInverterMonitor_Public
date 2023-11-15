using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
  public sealed class StationAggregationYear : StationAggregationReporterData
  {
    [JsonPropertyName("dayEnergy")]
    public string TotalEnergy { get; set; } = "";

    [JsonPropertyName("dayEnergy1")]
    public string MonthEnergy1 { get; set; } = "";
    [JsonPropertyName("dayEnergy2")]
    public string MonthEnergy2 { get; set; } = "";
    [JsonPropertyName("dayEnergy3")]
    public string MonthEnergy3 { get; set; } = "";
    [JsonPropertyName("dayEnergy4")]
    public string MonthEnergy4 { get; set; } = "";
    [JsonPropertyName("dayEnergy5")]
    public string MonthEnergy5 { get; set; } = "";
    [JsonPropertyName("dayEnergy6")]
    public string DayEnergy6 { get; set; } = "";
    [JsonPropertyName("dayEnergy7")]
    public string DayEnergy7 { get; set; } = "";
    [JsonPropertyName("dayEnergy8")]
    public string DayEnergy8 { get; set; } = "";
    [JsonPropertyName("dayEnergy9")]
    public string DayEnergy9 { get; set; } = "";
    [JsonPropertyName("dayEnergy10")]
    public string DayEnergy10 { get; set; } = "";
    [JsonPropertyName("dayEnergy11")]
    public string DayEnergy11 { get; set; } = "";
    [JsonPropertyName("dayEnergy12")]
    public string DayEnergy12 { get; set; } = "";
  }
}