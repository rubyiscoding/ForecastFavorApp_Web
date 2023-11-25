using Newtonsoft.Json;

namespace ForecastFavorLib.Models
{
    public class Hour
    {
        [JsonProperty("time_epoch")]
        public long TimeEpoch { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("temp_c")]
        public double TempC { get; set; }

        [JsonProperty("temp_f")]
        public double TempF { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }

        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }

        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public int Cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double FeelsLikeC { get; set; }

        [JsonProperty("windchill_c")]
        public double WindChillC { get; set; }

        [JsonProperty("heatindex_c")]
        public double HeatIndexC { get; set; }

        [JsonProperty("dewpoint_c")]
        public double DewPointC { get; set; }

        [JsonProperty("will_it_rain")]
        public int WillItRain { get; set; }

        [JsonProperty("chance_of_rain")]
        public int ChanceOfRain { get; set; }

        [JsonProperty("will_it_snow")]
        public int WillItSnow { get; set; }

        [JsonProperty("chance_of_snow")]
        public int ChanceOfSnow { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }
}
