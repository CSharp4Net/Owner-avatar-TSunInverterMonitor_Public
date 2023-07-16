using NZZ.TSIM.Contracts.Models;

namespace NZZ.TSIM.Contracts
{
  /// <summary>
  /// Schnittstelle für die Kommunikation mit der API von T-SUN.
  /// </summary>
  public interface IConnection
  {
    /// <summary>
    /// Führt an eine Anmeldung durch.
    /// </summary>
    /// <param name="credentials">Anmeldeinformationen</param>
    /// <returns></returns>
    Task<LoginResult> Login(LoginCredentials credentials);
    /// <summary>
    /// Führt eine Abmeldung durch.
    /// </summary>
    /// <returns></returns>
    Task<bool> Logout();

    /// <summary>
    /// Listet alle registrierten Stationen auf.
    /// Gibt NULL zurück, wenn die Stationen nicht abgefragt werden konnten.
    /// </summary>
    /// <returns></returns>
    Task<List<Station>?> GetStations();
    /// <summary>
    /// Gibt detaillierte Information zu einer Station zurück oder NULL, wenn die Daten nicht abgefragt werden konnten.
    /// </summary>
    /// <param name="stationId">id der Station</param>
    /// <returns></returns>
    Task<StationDetails?> GetStationDetails(int stationId);

    /// <summary>
    /// Gibt detaillierte aggregierte Werte zu einer Station für einen bestimmten Tag zurück oder NULL, wenn die Daten nicht abgefragt werden konnten.
    /// </summary>
    /// <param name="station">Station</param>
    /// <param name="date">Datum</param>
    /// <returns></returns>
    Task<StationAggregationDay?> GetStationAggregationOfDay(Station station, DateTime date);
    /// <summary>
    /// Gibt detaillierte aggregierte Werte zu einer Station für einen bestimmten Tag zurück oder NULL, wenn die Daten nicht abgefragt werden konnten.
    /// </summary>
    /// <param name="guid">Guid der Station</param>
    /// <param name="year">Jahr</param>
    /// <param name="month">Monat (1 - 12)</param>
    /// <returns></returns>
    Task<StationAggregationMonth?> GetStationAggregationOfMonth(string guid, int year, int month);
    /// <summary>
    /// Gibt detaillierte aggregierte Werte zu einer Station für einen bestimmten Tag zurück oder NULL, wenn die Daten nicht abgefragt werden konnten.
    /// </summary>
    /// <param name="guid">Guid der Station</param>
    /// <param name="year">Jahr</param>
    /// <returns></returns>
    Task<StationAggregationYear?> GetStationAggregationOfYear(string guid, int year);
  }
}