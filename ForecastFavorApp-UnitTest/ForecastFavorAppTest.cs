using Newtonsoft.Json;
using ForecastFavorLib.Models;

namespace ForecastFavorApp_UnitTest
{
    // test class for the CurrentWeatherResponseTests
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

    // test class for the ConditionTest
    [TestClass]
    public class ConditionTest
    {
        [TestMethod]
        public void ConditionSerializationTest()
        {
            Condition condition = new Condition
            {
                Text = "Clear",
                Icon = "https://example.com/clear.png",
                Code = 800
            };
            string json = JsonConvert.SerializeObject(condition);
            Assert.IsNotNull(json);
            Condition deserializedCondition = JsonConvert.DeserializeObject<Condition>(json);
            Assert.IsNotNull(deserializedCondition);
            Assert.AreEqual("Clear", deserializedCondition.Text);
            Assert.AreEqual("https://example.com/clear.png", deserializedCondition.Icon);
            Assert.AreEqual(800, deserializedCondition.Code);
        }
    }

    // test class for the DayTest
    [TestClass]
    public class DayTest
    {
        [TestMethod]
        public void DaySerializationTest()
        {
            Day day = new Day
            {
                MaxTempC = 28.5,
                MinTempC = 18.5,
                Condition = new Condition
                {
                    Text = "Partly cloudy",
                    Icon = "https://example.com/partly-cloudy.png",
                    Code = 801
                },
                AvgTempC = 23.5,
                MaxWindKph = 15.0,
                TotalPrecipIn = 0.5,
                TotalSnowCm = 2.0,
                AvgHumidity = 60.0,
                DailyChanceOfRain = 30,
                DailyChanceOfSnow = 10
            };
            string json = JsonConvert.SerializeObject(day);
            Assert.IsNotNull(json);
            Day deserializedDay = JsonConvert.DeserializeObject<Day>(json);
            Assert.IsNotNull(deserializedDay);
            Assert.AreEqual(28.5, deserializedDay.MaxTempC);
            Assert.AreEqual(18.5, deserializedDay.MinTempC);
            Assert.IsNotNull(deserializedDay.Condition);
            Assert.AreEqual("Partly cloudy", deserializedDay.Condition.Text);
            Assert.AreEqual("https://example.com/partly-cloudy.png", deserializedDay.Condition.Icon);
            Assert.AreEqual(801, deserializedDay.Condition.Code);
            Assert.AreEqual(23.5, deserializedDay.AvgTempC);
            Assert.AreEqual(15.0, deserializedDay.MaxWindKph);
            Assert.AreEqual(0.5, deserializedDay.TotalPrecipIn);
            Assert.AreEqual(2.0, deserializedDay.TotalSnowCm);
            Assert.AreEqual(60.0, deserializedDay.AvgHumidity);
            Assert.AreEqual(30, deserializedDay.DailyChanceOfRain);
            Assert.AreEqual(10, deserializedDay.DailyChanceOfSnow);
        }
    }

}
