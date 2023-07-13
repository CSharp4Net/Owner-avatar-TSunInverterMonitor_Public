using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal sealed class LoginPayload
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; } = "";
        [JsonPropertyName("password")]
        public string Password { get; set; } = "";
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = "";
    }
}
