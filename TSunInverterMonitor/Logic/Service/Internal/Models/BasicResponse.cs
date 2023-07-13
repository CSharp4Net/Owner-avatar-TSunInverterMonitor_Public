using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Internal.Models
{
    internal class BasicResponse
    {
        [JsonConstructor]
        public BasicResponse()
        {
            Message = "";
        }

        [JsonPropertyName("msg")]
        public string Message { get; set; }
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}