using NZZ.TSIM.Contracts;
using NZZ.TSIM.Contracts.Models;
using System.Text.Json;

namespace NZZ.TSIM.Service.Test
{
    [TestClass]
    public class ConnectorTest
    {
        [TestMethod]
        public void TestLogin()
        {
            try
            {
                IConnection connection = new Connection();

                LoginCredentials credentials = LoadCredentials();

                var loginResult = connection.Login(credentials).Result;

                Assert.IsTrue(loginResult.Successful, loginResult.ErrorMessage);

                var loggedOut = connection.Logout().Result;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod]
        public void GetStations()
        {
            try
            {
                IConnection connection = new Connection();

                LoginCredentials credentials = LoadCredentials();

                var loginResult = connection.Login(credentials).Result;

                if (!loginResult.Successful)
                    Assert.IsTrue(loginResult.Successful, loginResult.ErrorMessage);

                var stations = connection.GetStations().Result;

                Assert.IsNotNull(stations, loginResult.ErrorMessage);

                var loggedOut = connection.Logout().Result;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod]
        public void GetStationDetails()
        {
            try
            {
                IConnection connection = new Connection();

                LoginCredentials credentials = LoadCredentials();

                var loginResult = connection.Login(credentials).Result;

                if (!loginResult.Successful)
                    Assert.IsTrue(loginResult.Successful, loginResult.ErrorMessage);

                var stations = connection.GetStations().Result!;

                var stationDetails = connection.GetStationDetails(stations[0].Id).Result;

                Assert.IsNotNull(stationDetails, loginResult.ErrorMessage);

                var loggedOut = connection.Logout().Result;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod]
        public void GetStationAggregation()
        {
            try
            {
                IConnection connection = new Connection();

                LoginCredentials credentials = LoadCredentials();

                var loginResult = connection.Login(credentials).Result;

                if (!loginResult.Successful)
                    Assert.IsTrue(loginResult.Successful, loginResult.ErrorMessage);

                var stations = connection.GetStations().Result!;

                List<string> guids = new List<string> { stations[0].Guid };

                var aggregationOfDay = connection.GetStationAggregationOfDay(guids, DateTime.Today).Result;
                var aggregationOfMonth = connection.GetStationAggregationOfMonth(guids, 2023, 7).Result;
                var aggregationOfYear = connection.GetStationAggregationOfYear(guids, 2023).Result;

                Assert.IsNotNull(aggregationOfDay, loginResult.ErrorMessage);
                Assert.IsNotNull(aggregationOfMonth, loginResult.ErrorMessage);
                Assert.IsNotNull(aggregationOfYear, loginResult.ErrorMessage);

                var loggedOut = connection.Logout().Result;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }

        private LoginCredentials LoadCredentials()
        {
            // Implement your own way to get credentials, e.g. hard coded
            //return new LoginCredentials
            //{
            //     UserName = "your account name",
            //     Password = "your password"
            //};

            string fileContent = File.ReadAllText("F:\\Projects\\TSUN-Credentials.txt");

            return JsonSerializer.Deserialize<LoginCredentials>(fileContent);
        }
    }
}