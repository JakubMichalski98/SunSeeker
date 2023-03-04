using SunSeeker.Data;
using SunSeeker.Models;

namespace SunSeeker.Repositories
{
    public class WeatherRepo : IWeatherRepo
    {
        private readonly AppDbContext _context;

        public WeatherRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddWeatherForecast(WeatherModel location)
        {
            await _context.Weathers.AddAsync(location);
            await _context.SaveChangesAsync();
        }
    }
}
