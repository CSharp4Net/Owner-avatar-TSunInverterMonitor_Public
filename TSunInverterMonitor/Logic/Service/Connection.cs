using NZZ.TSIM.Contracts;
using NZZ.TSIM.Contracts.Models;
using NZZ.TSIM.Core;
using NZZ.TSIM.Service.Internal.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Web;

namespace NZZ.TSIM.Service
{
  public sealed class Connection : IConnection
  {
    public Connection(ServiceSettings settings, string logFolderPath)
    {
      this.settings = settings;
      logger = new FileLogger("Service", logFolderPath);

      client = new HttpClient();
      client.BaseAddress = new Uri(settings.RootUrl);
      client.DefaultRequestHeaders.Authorization = null;

      Connected = false;
    }

    private HttpClient client;
    private ServiceSettings settings;
    private ILogger logger;

    public bool Connected { get; private set; }

    public void Reset(ServiceSettings settings)
    {
      this.settings = settings;

      client = new HttpClient();
      client.BaseAddress = new Uri(settings.RootUrl);
      client.DefaultRequestHeaders.Authorization = null;

      Connected = false;
    }

    public async Task<LoginResult> Login(LoginCredentials credentials)
    {
      // CaptchaImage abfrage, die Antwort enthält eine UUID für die Anmeldung
      logger.LogDebug("GET captcha image");
      HttpResponseMessage message = await client.GetAsync($"{settings.ApiPattern}/captchaImage");

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return new LoginResult($"{message.StatusCode}/{message.ReasonPhrase}");
      }

      var imageResponse = await HttpContentToObject<CaptchaImageResponse>(message.Content)!;

      var payload = new LoginPayload
      {
        UserName = credentials.UserName,
        Password = credentials.Password,
        Uuid = imageResponse.Uuid
      };

      JsonContent jsonContent = JsonContent.Create(payload, typeof(LoginPayload));
      // Anmeldung mit UUID und Credentials durchführen
      logger.LogInfo($"POST login as '{payload.UserName}' with uuid '{payload.Uuid}' from captcha image");
      message = await client.PostAsync($"{settings.ApiPattern}/login", jsonContent);

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return new LoginResult($"{message.StatusCode}/{message.ReasonPhrase}");
      }

      var loginResponse = await HttpContentToObject<LoginResponse>(message.Content)!;

      if (loginResponse.Code != 200)
      {
        logger.LogWarning($"Error response with code '{loginResponse.Code}' and reason '{loginResponse.Message}'!");
        return new LoginResult($"{loginResponse.Code}/{loginResponse.Message}");
      }

      // Token der Anmeldung übernehmen
      logger.LogDebug($"Set bearer token for communication");
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
      logger.LogDebug("GET logout");
      HttpResponseMessage message = await client.GetAsync($"{settings.ApiPattern}/logout");

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return false;
      }

      Connected = false;

      client.DefaultRequestHeaders.Authorization = null;

      BasicResponse? response = await HttpContentToObject<BasicResponse>(message.Content);

      return response!.Code == 200;
    }

    public async Task<List<Station>?> GetStations()
    {
      logger.LogInfo($"GET all stations");
      HttpResponseMessage message = await client!.GetAsync($"{settings!.ApiPattern}/system/station/listWithoutPagingForMap");

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return null;
      }

      var response = await HttpContentToObject<StationsResponse>(message.Content);

      return response.Stations;
    }

    public async Task<StationDetails?> GetStationDetails(int stationId)
    {
      logger.LogInfo($"GET details of station '{stationId}'");
      HttpResponseMessage message = await client.GetAsync($"{settings.ApiPattern}/system/station/{stationId}");

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return null;
      }

      var response = await HttpContentToObject<StationDetailsResponse>(message.Content);

      return response.Details;
    }

    public async Task<StationAggregationDay?> GetStationAggregationOfDay(Station station, DateTime date)
    {
      StationAggregationPayload payload = new StationAggregationPayload
      {
        BusinessType = "1",
        PowerStationGuids = station.Guid,
        Mode = "day",
        Date = date.ToString("yyyy-MM-dd")
      };

      // Tages-Total abrufen
      JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
      logger.LogInfo($"POST aggregation data request of station '{station.Guid}' for day");
      HttpResponseMessage message = await client.PostAsync($"{settings.ApiPattern}/system/station/getStationAggregationReporterData", jsonContent);

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return null;
      }

      var dayResponse = await HttpContentToObject<StationAggregationResponse<StationAggregationDay>>(message.Content)!;

      StationAggregationDay? result = dayResponse!.Data.FirstOrDefault();

      if (result == null)
      {
        logger.LogWarning($"Stations aggregation data result is empty or missing!");
        return null;
      }

      // Tages-Einzelwerte abrufen
      logger.LogInfo($"POST aggregation data details request of station '{station.Guid}'");
      message = await client.GetAsync($"{settings.ApiPattern}/system/station/getStationAggregationChartData?powerStationGuid={station.Guid}&group=hour&date={date.ToString("yyyy-MM-dd")}&series=total_peak_power%2Cday_energy%2Cincoming&timezone={HttpUtility.UrlEncode(station.TimeZoneOffset)}");

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
      {
        logger.LogWarning($"Error response with code '{message.StatusCode}' and reason '{message.ReasonPhrase}'!");
        return null;
      }

      var peaksResponse = await HttpContentToObject<StationAggregationPeaksResponse<StationAggregationDayPeaks>>(message.Content)!;

      result.Peaks = peaksResponse!.Data!;

      return result;
    }

    public async Task<StationAggregationMonth?> GetStationAggregationOfMonth(string guid, int year, int month)
    {
      StationAggregationPayload payload = new StationAggregationPayload
      {
        BusinessType = "1",
        PowerStationGuids = guid,
        Mode = "month",
        Date = $"{year}-{month:00}"
      };

      JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
      logger.LogInfo($"POST aggregation data request of station '{guid}' for month");
      HttpResponseMessage message = await client.PostAsync($"{settings.ApiPattern}/system/station/getStationAggregationReporterData", jsonContent);

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
        return null;

      var response = await HttpContentToObject<StationAggregationResponse<StationAggregationMonth>>(message.Content)!;

      return response.Data.FirstOrDefault();
    }

    public async Task<StationAggregationYear?> GetStationAggregationOfYear(string guid, int year)
    {
      StationAggregationPayload payload = new StationAggregationPayload
      {
        BusinessType = "1",
        PowerStationGuids = guid,
        Mode = "year",
        Date = $"{year}"
      };

      JsonContent jsonContent = JsonContent.Create(payload, typeof(StationAggregationPayload));
      logger.LogInfo($"POST aggregation data request of station '{guid}' for year");
      HttpResponseMessage message = await client.PostAsync($"{settings.ApiPattern}/system/station/getStationAggregationReporterData", jsonContent);

      if (message.StatusCode != System.Net.HttpStatusCode.OK)
        return null;

      var response = await HttpContentToObject<StationAggregationResponse<StationAggregationYear>>(message.Content)!;

      return response.Data.FirstOrDefault();
    }

    private async Task<T?> HttpContentToObject<T>(HttpContent content)
    {
      string contentText = await content.ReadAsStringAsync();
      try
      {       
        return JsonSerializer.Deserialize<T>(contentText);
      }
      catch (Exception ex)
      {
        logger.LogError($"Error while parse content: {contentText}");
        logger.LogException(ex);
        return default;
      }
    }
  }
}