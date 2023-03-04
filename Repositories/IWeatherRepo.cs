using SunSeeker.Models;

namespace SunSeeker.Repositories
{
    public interface IWeatherRepo
    {
        //public void UpdateWeatherForecast(WeatherModel location);

        public Task AddWeatherForecast(WeatherModel location);

        //public void DeleteWeatherForecast(WeatherModel location);
    }
}
