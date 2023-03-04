namespace SunSeeker.Models
{
    public class WeatherResponseModel
    {
        public RequestModel request { get; set; }
        public LocationModel location { get; set; }
        public CurrentModel current { get; set; }
    }
}
