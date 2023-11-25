using Newtonsoft.Json;

namespace ForecastFavorLib.Models
{
    public class ForecastDay
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("day")]
        public Day Day { get; set; }

        [JsonProperty("hour")]
        public List<Hour> HourlyForecasts { get; set; }
        
    }
}
