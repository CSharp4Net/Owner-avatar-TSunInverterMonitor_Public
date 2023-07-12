# TSunInverterMonitor

## General info
Abrufen und Anzeigen von Daten zu T-SUN Wechselrichtern, als Alternative zur T-SUN App und dem Web-UI.
* [Login & Logout](#Login-&-Logout)
* [Alle Stationen abrufen](#Alle-Stationen-abrufen)
* [Details einer Station abrufen](#Details-einer-Station-abrufen)
* [Historie einer Station abrufen](#Historie-einer-Station-abrufen)

## Getting Started

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
