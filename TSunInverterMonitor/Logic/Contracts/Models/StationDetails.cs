using System.Text.Json.Serialization;

namespace NZZ.TSIM.Contracts.Models
{
  public sealed class StationDetails : Station
  {
    [JsonPropertyName("statusNamed")]
    public string StatusNamed { get; set; } = "";
    [JsonPropertyName("location")]
    public string Location { get; set; } = "";

    [JsonPropertyName("dayEnergy")]
    public double CurrentDayEnergy { get; set; }
    [JsonPropertyName("dayEnergyNamed")]
    public string CurrentDayEnergyNamed { get; set; } = "";
    [JsonPropertyName("monthEnergy")]
    public double CurrentMonthEnergy { get; set; }
    [JsonPropertyName("monthEnergyNamed")]
    public string CurrentMonthEnergyNamed { get; set; } = "";
    [JsonPropertyName("yearEnergy")]
    public double CurrentYearEnergy { get; set; }
    [JsonPropertyName("yearEnergyNamed")]
    public string CurrentYearEnergyNamed { get; set; } = "";
    [JsonPropertyName("totalEnergy")]
    public double TotalEnergy { get; set; }
    [JsonPropertyName("totalEnergyNamed")]
    public string TotalEnergyNamed { get; set; } = "";
    [JsonPropertyName("totalActivePower")]
    public double ActivePower { get; set; }
    [JsonPropertyName("totalActivePowerNamed")]
    public string ActivePowerNamed { get; set; } = "";
    [JsonPropertyName("totalPeakPower")]
    public double TodayPeakPower { get; set; }

    [JsonPropertyName("co2Reduced")]
    public string Co2Reduced { get; set; } = "";

    [JsonPropertyName("lastDataUpdateTime")]
    public DateTime LastDataUpdateTime { get; set; }

    [JsonPropertyName("timeZone")]
    public new string TimeZone { get; set; } = "";
    [JsonPropertyName("timezoneOffset")]
    public new string TimeZoneOffset { get; set; } = "";

    [JsonPropertyName("installedCapacity")]
    public double InstalledCapacity { get; set; }
    [JsonPropertyName("installedCapacityNamed")]
    public string InstalledCapacityNamed { get; set; } = "";
  }
}