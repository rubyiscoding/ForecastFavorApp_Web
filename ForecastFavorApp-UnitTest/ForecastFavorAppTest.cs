using Newtonsoft.Json;
using ForecastFavorLib.Models;

namespace ForecastFavorApp_UnitTest;

[TestClass]
public class ForecastFavorAppTest
{
    [TestMethod]
    public void CurrentWeatherResponseTests()
    {
        string json = @"{
                'location': {
                    'latitude': 40.7128,
                    'longitude': -74.0060
                },
                'current': {
                    'last_updated': '2023-12-01 12:00:00',
                    'temp_c': 25.5,
                    'temp_f': 77.9,
                    'condition': {
                        'text': 'Clear',
                        'icon': 'https://example.com/clear.png'
                    },
                    'pressure_in': 29.92,
                    'humidity': 50,
                    'cloud': 20,
                    'feelslike_c': 26.0,
                    'wind_kph': 10.0
                }
            }";
        CurrentWeatherResponse response = JsonConvert.DeserializeObject<CurrentWeatherResponse>(json);
        Assert.IsNotNull(response);
        Assert.IsNotNull(response.Location);
        Assert.IsNotNull(response.Current);
        Assert.AreEqual(40.7128, response.Location.Latitude);
        Assert.AreEqual(-74.0060, response.Location.Longitude);
        Assert.AreEqual("2023-12-01 12:00:00", response.Current.LastUpdated);
        Assert.AreEqual(25.5, response.Current.TemperatureC);
        Assert.AreEqual(77.9, response.Current.TemperatureF);
    }
}