using Microsoft.EntityFrameworkCore;
using SunSeeker.API;
using SunSeeker.Models;

namespace SunSeeker.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public AppDbContext()
        {
            
        }

        public DbSet<WeatherModel> Weathers { get; set; }


    }
}
