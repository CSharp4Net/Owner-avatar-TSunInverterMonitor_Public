﻿using System.Text.Json.Serialization;

namespace NZZ.TSIM.Service.Models
{
    internal sealed class LoginResponse : BasicResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; } = "";
    }
}