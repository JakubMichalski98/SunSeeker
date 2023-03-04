using Microsoft.AspNetCore.Mvc;
using SunSeeker.API;
using SunSeeker.Models;
using SunSeeker.Repositories;
using System.Diagnostics;

namespace SunSeeker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherRepo _weatherRepo;

        public HomeController(IWeatherRepo weatherRepo)
        {
            _weatherRepo = weatherRepo;
        }

        public IActionResult Index(string message)
        {
            MessageModel messageModel = new();
            messageModel.Message = message;
            return View(messageModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewForecast(string weatherLocation)
        {
            WeatherModel weatherModel = await new ApiCaller().MakeCall(weatherLocation);

            return View(weatherModel);
        }

        public async Task<IActionResult> SaveToDatabase(WeatherModel? weatherModel)
        {
            if (weatherModel != null)
            {
                await _weatherRepo.AddWeatherForecast(weatherModel);
            }

            return RedirectToAction("Index", "Home", new { message = "Saved to database!" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}