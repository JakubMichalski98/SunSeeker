using System.ComponentModel.DataAnnotations.Schema;

namespace SunSeeker.Models
{
    public class CurrentModel
    {
        public string? observation_time { get; set; }
        public int temperature { get; set; }
        public List<string>? weather_descriptions { get; set; } = new();

        public List<string>? weather_icons { get; set; } = new();

        public int MyProperty { get; set; }

    }
}
