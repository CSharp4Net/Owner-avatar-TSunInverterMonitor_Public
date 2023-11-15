# Achtung @ 2023-11-15

Die Weiterentwicklung wurde eingestellt, da der Anbieter TSUN in Eigenregie Messwerte löscht, nur weil diese ohne WLAN-Verbindung und damit ohne Zeitstemepl erfasst wurden.
D.h. die erfasste Gesamtleistung besteht nur aus Messwerten mit Zeitstempel, alles andere wird ignoriert.

Des Weiteren ist die Datensicherung bei TSUN lückenhaft und es wird scheinbar nicht an Verbesserungen gearbeitet.

# TSunInverterMonitor

## General info
Abrufen und Anzeigen von Daten zu T-SUN Wechselrichtern, als Alternative zur T-SUN App und dem Web-UI.

Die Lösung enthält eine .NET-Solution, unterteilt in mehrere C#-Projekte.

## Getting Started
* [Login & Logout](#Login-&-Logout)
* [Alle Stationen abrufen](#Alle-Stationen-abrufen)
* [Details einer Station abrufen](#Details-einer-Station-abrufen)
* [Historie einer Station abrufen](#Historie-einer-Station-abrufen)

Als UI beinhaltet die Lösung
1. Eine Winform-Anwendung (Funktional und einsatzbereit)
2. Eine WPF-Lösung (begonnen, aber nicht funktional)
3. Eine MAUI-Lösung (angedacht)

Die Logik zur Kommunikation mit T-SUN ist in das C#-Projekt Service ausgelagert.
Nachfolgend werden die Funktionen zur Verwendung dieser Logik beschrieben.

### Login & Logout
```
IConnection connection = new Connection();
LoginCredentials credentials = new LoginCredentials
{
    UserName = "your account name",
    Password = "your password"
};

// Login
var loginResult = connection.Login(credentials).Result;
if (!loginResult.Successful) 
  Assert.IsTrue(loginResult.Successful, loginResult.ErrorMessage);

// Logout
var loggedOut = connection.Logout().Result;
```

### Alle Stationen abrufen
```
var stations = connection.GetStations().Result;

// Wenn NULL, Fehler beim Abrufen
Assert.IsNotNull(stations, loginResult.ErrorMessage);
```

### Details einer Station abrufen
```
int stationId = 123456790; // set your station id here

var stationDetails = connection.GetStationDetails(stationId).Result;

// Wenn NULL, Fehler beim Abrufen
Assert.IsNotNull(stationDetails, loginResult.ErrorMessage);
```

### Historie einer Station abrufen
```
List<string> guids = new List<string> { "guid of your station" }; // add your station guid(s) here

var aggregationOfDay = connection.GetStationAggregationOfDay(guids, DateTime.Today).Result;
var aggregationOfMonth = connection.GetStationAggregationOfMonth(guids, 2023, 7).Result;
var aggregationOfYear = connection.GetStationAggregationOfYear(guids, 2023).Result;
```
