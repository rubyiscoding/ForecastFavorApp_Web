using Microsoft.AspNetCore.Mvc;
using ForecastFavorLib.Services;
using System.Threading.Tasks;

// This is our WeatherController that deals with weather-related pages
namespace ForecastFavorApp.Controllers
{
    // Inherits from Controller so we get all the MVC controller functionality
    public class WeatherController : Controller
    {
        // This service lets us get weather data
        private readonly IWeatherService _weatherService;

        // Constructor: .NET gives us an IWeatherService when it makes this controller
        public WeatherController(IWeatherService weatherService)
        {
            // Save the service so we can use it later
            _weatherService = weatherService;
        }

        // The main page of our weather section
        public async Task<IActionResult> Index()
        {
            // Ask the weather service for the weather in London and wait for it to come back
            var currentWeather = await _weatherService.GetCurrentWeatherAsync("Sudbury");
            
            // Send the weather data to our page to be displayed
            return View(currentWeather);
        }

        
    }
}
