using NZZ.TSIM.Contracts;
using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Service.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json;

namespace NZZ.TSIM.Service
{
    public sealed class Connection : IConnection
    {
        public Connection()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://www.talent-monitoring.com");
        }

        private HttpClient client;

        public bool Connected { get; private set; }

        public async Task<LoginResult> Login(LoginCredentials credentials)
        {
            client.DefaultRequestHeaders.Authorization = null;

            // CaptchaImage abfrage, die Antwort enthält eine UUID für die Anmeldung
            HttpResponseMessage message = await client.GetAsync("prod-api/captchaImage");

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return new LoginResult
                {
                    Successful = false,
                    ErrorMessage = $"{message.StatusCode}/{message.ReasonPhrase}"
                };

            var imageResponse = await HttpContentToObject<CaptchaImageResponse>(message.Content)!;

            var payload = new LoginPayload
            {
                UserName = credentials.UserName,
                Password = credentials.Password,
                Uuid = imageResponse.Uuid
            };

            JsonContent jsonContent = JsonContent.Create(payload, typeof(LoginPayload));
            // Anmeldung mit UUID und Credentials durchführen
            message = await client.PostAsync("prod-api/login", jsonContent);

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return new LoginResult
                {
                    Successful = false,
                    ErrorMessage = $"{message.StatusCode}/{message.ReasonPhrase}"
                };

            var loginResponse = await HttpContentToObject<LoginResponse>(message.Content)!;

            // Token der Anmeldung übernehmen
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loginResponse.Token);

            Connected = true;

            return new LoginResult
            {
                Successful = true
            };
        }

        public async Task<bool> Logout()
        {
            if (!Connected)
                return true;

            // Abmeldung mit Token senden
            HttpResponseMessage message = await client.GetAsync("prod-api/logout");

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return false;

            client.DefaultRequestHeaders.Authorization = null;

            BasicResponse? response = await HttpContentToObject<BasicResponse>(message.Content);

            return response!.Code == 200;
        }

        public async Task<List<Station>?> GetStations()
        {
            HttpResponseMessage message = await client.GetAsync("prod-api/system/station/listWithoutPagingForMap");

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var response = await HttpContentToObject<StationsResponse>(message.Content);

            return response.Stations;
        }

        public async Task<StationDetails?> GetStationDetails(int stationId)
        {
            HttpResponseMessage message = await client.GetAsync($"prod-api/system/station/{stationId}");

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var response = await HttpContentToObject<StationDetailsResponse>(message.Content);

            return response.Details;
        }

        public async Task<StationAggregationDay?> GetStationAggregationOfDay(List<string> guids, DateTime date)
        {
            StationAggregationPayload payload = new StationAggregationPayload
            {
                BusinessType = "1",
                PowerStationGuids = string.Join(",", guids),
                Mode = "day",
                Date = date.ToString("yyyy-MM-dd")
            };

            JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
            // Anmeldung mit UUID und Credentials durchführen
            HttpResponseMessage  message = await client.PostAsync("prod-api/system/station/getStationAggregationReporterData", jsonContent);

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var response = await HttpContentToObject<StationAggregationResponse<StationAggregationDay>>(message.Content)!;

            return response.Data.FirstOrDefault();
        }

        public async Task<StationAggregationMonth?> GetStationAggregationOfMonth(List<string> guids, int year, int month)
        {
            StationAggregationPayload payload = new StationAggregationPayload
            {
                BusinessType = "1",
                PowerStationGuids = string.Join(",", guids),
                Mode = "month",
                Date = $"{year}-{month:00}"
            };

            JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
            // Anmeldung mit UUID und Credentials durchführen
            HttpResponseMessage message = await client.PostAsync("prod-api/system/station/getStationAggregationReporterData", jsonContent);

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var response = await HttpContentToObject<StationAggregationResponse<StationAggregationMonth>>(message.Content)!;

            return response.Data.FirstOrDefault();
        }

        public async Task<StationAggregationYear?> GetStationAggregationOfYear(List<string> guids, int year)
        {
            StationAggregationPayload payload = new StationAggregationPayload
            {
                BusinessType = "1",
                PowerStationGuids = string.Join(",", guids),
                Mode = "year",
                Date = $"{year}"
            };

            JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
            // Anmeldung mit UUID und Credentials durchführen
            HttpResponseMessage message = await client.PostAsync("prod-api/system/station/getStationAggregationReporterData", jsonContent);

            if (message.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            var response = await HttpContentToObject<StationAggregationResponse<StationAggregationYear>>(message.Content)!;

            return response.Data.FirstOrDefault();
        }

        private async Task<T> HttpContentToObject<T>(HttpContent content)
        {
            string contentText = await content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(contentText)!;
        }
    }
}