using Newtonsoft.Json;
using ForecastFavorLib.Models;

namespace ForecastFavorApp_UnitTest
{
    [TestClass]
    public class ForecastFavorAppTest
    {
        [TestMethod]
        public void CurrentWeatherResponseTests()
        {
            string json = @"{
                'location': {
                    'name': 'CityName',
                    'region': 'RegionName',
                    'country': 'CountryName',
                    'lat': 40.7128,
                    'lon': -74.0060,
                    'tz_id': 'TimeZoneId',
                    'localtime': '2023-12-01 12:00:00'
                },
                'current': {
                    'last_updated': '2023-12-01 12:00:00',
                    'temp_c': 25.5,
                    'temp_f': 77.9,
                    'condition': {
                        'text': 'Clear',
                        'icon': 'https://example.com/clear.png',
                        'code': 800
                    },
                    'pressure_in': 29.92,
                    'humidity': 50,
                    'cloud': 20,
                    'feelslike_c': 26.0,
                    'wind_kph': 10.0
                }
            }";

            try
            {
                CurrentWeatherResponse response = JsonConvert.DeserializeObject<CurrentWeatherResponse>(json);
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.Location);
                Assert.IsNotNull(response.Current);
                Assert.AreEqual("CityName", response.Location?.Name);
                Assert.AreEqual("RegionName", response.Location?.Region);
                Assert.AreEqual("CountryName", response.Location?.Country);
                Assert.AreEqual(40.7128, response.Location?.Latitude);
                Assert.AreEqual(-74.0060, response.Location?.Longitude);
                Assert.AreEqual("TimeZoneId", response.Location?.TimeZoneId);
                Assert.AreEqual("2023-12-01 12:00:00", response.Location?.LocalTime);
                Assert.AreEqual("2023-12-01 12:00:00", response.Current.LastUpdated);
                Assert.AreEqual(25.5, response.Current.TemperatureC);
                Assert.AreEqual(77.9, response.Current.TemperatureF);
                Assert.IsNotNull(response.Current.Condition);
                Assert.AreEqual("Clear", response.Current.Condition.Text);
                Assert.AreEqual("https://example.com/clear.png", response.Current.Condition.Icon);
                Assert.AreEqual(800, response.Current.Condition.Code);
                Assert.AreEqual(29.92, response.Current.PressureIn);
                Assert.AreEqual(50, response.Current.Humidity);
                Assert.AreEqual(20, response.Current.Cloud);
                Assert.AreEqual(26.0, response.Current.FeelsLikeC);
                Assert.AreEqual(10.0, response.Current.WindKph);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
                throw;
            }
        }
    }
}
