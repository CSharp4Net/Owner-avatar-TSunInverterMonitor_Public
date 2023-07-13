using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class CaptchaImageResponse : BasicResponse
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = "";
    }
}