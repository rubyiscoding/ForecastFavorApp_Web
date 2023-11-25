using Newtonsoft.Json;

namespace ForecastFavorLib.Models
{
    public class CurrentWeather
    {
        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("temp_c")]
        public double TemperatureC { get; set; }

        [JsonProperty("temp_f")]
        public double TemperatureF { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        
        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public int FeelsLikeC { get; set; }
        
        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }
        
    }
}
