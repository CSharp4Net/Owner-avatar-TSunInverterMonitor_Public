namespace NZZ.TSIM.Contracts.Models
{
    public sealed class ServiceSettings
    {
        public string RootUrl { get; set; } = "https://www.talent-monitoring.com";
        public string ApiPattern { get; set; } = "prod-api";

        public AggregationDataLogSettings AggregationDataLogSettings { get; set; } = new AggregationDataLogSettings();
    }
}