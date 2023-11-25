using Newtonsoft.Json;

namespace ForecastFavorLib.Models
{
    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTempC { get; set; }

        [JsonProperty("mintemp_c")]
        public double MinTempC { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("avgtemp_c")]
        public double AvgTempC { get; set; }

         [JsonProperty("maxwind_kph")]
        public double MaxWindKph { get; set; }

        [JsonProperty("totalprecip_in")]
        public double TotalPrecipIn { get; set; }

        [JsonProperty("totalsnow_cm")]
        public double TotalSnowCm { get; set; }

        [JsonProperty("avghumidity")]
        public double AvgHumidity { get; set; }

        [JsonProperty("daily_chance_of_rain")]
        public int DailyChanceOfRain { get; set; }

         [JsonProperty("daily_chance_of_snow")]
        public int DailyChanceOfSnow { get; set; }
    }
}
