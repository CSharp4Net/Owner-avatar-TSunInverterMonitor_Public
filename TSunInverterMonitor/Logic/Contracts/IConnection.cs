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
        /// GIbt detaillierte Information zu einer Station zurück.
        /// </summary>
        /// <param name="stationId">id der Station</param>
        /// <returns></returns>
        Task<StationDetails?> GetStationDetails(int stationId);

        /// <summary>
        /// GIbt detaillierte aggregierte Werte von einer oder mehreren Stationen für einen bestimmten Tag zurück.
        /// </summary>
        /// <param name="guids">Auflistung der Station-Guids</param>
        /// <param name="date">Datum</param>
        /// <returns></returns>
        Task<StationAggregationDay?> GetStationAggregationOfDay(List<string> guids, DateTime date);
        /// <summary>
        /// GIbt detaillierte aggregierte Werte von einer oder mehreren Stationen für einen bestimmten Monat zurück.
        /// </summary>
        /// <param name="guids">Auflistung der Station-Guids</param>
        /// <param name="year">Jahr</param>
        /// <param name="month">Monat (1 - 12)</param>
        /// <returns></returns>
        Task<StationAggregationMonth?> GetStationAggregationOfMonth(List<string> guids, int year, int month);
        /// <summary>
        /// GIbt detaillierte aggregierte Werte von einer oder mehreren Stationen für ein bestimmtes Jahr zurück.
        /// </summary>
        /// <param name="guids">Auflistung der Station-Guids</param>
        /// <param name="year">Jahr</param>
        /// <returns></returns>
        Task<StationAggregationYear?> GetStationAggregationOfYear(List<string> guids, int year);
    }
}