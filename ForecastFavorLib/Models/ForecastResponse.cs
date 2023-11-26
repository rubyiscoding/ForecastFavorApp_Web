using System.Collections.Generic;
using Newtonsoft.Json;

namespace ForecastFavorLib.Models
{
    public class ForecastResponse
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public CurrentWeatherResponse Current { get; set; }

        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("forecastday")]
        public List<ForecastDay> ForecastDay { get; set; }
    }
}
