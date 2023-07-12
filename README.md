# TSunInverterMonitor

## General info
Abrufen und Anzeigen von Daten zu T-SUN Wechselrichtern, als Alternative zur T-SUN App und dem Web-UI.
* [Login & Logout](### Login & Logout)

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

// Get data
var stations = connection.GetStations().Result;
Assert.IsNotNull(stations, loginResult.ErrorMessage);

// do something, e.g. look in stations-member

// Logout
var loggedOut = connection.Logout().Result;
```
