namespace SunSeeker.Models
{
    public class WeatherModel
    {
        public int Id { get; set; }
        public string? observation_time { get; set; }
        public int temperature { get; set; }
        public string? weather_description { get; set; }
        public string? weather_icon { get; set; }
        public string? name { get; set; }
        public string? country { get; set; }
        public string? type { get; set; }
        public string? query { get; set; }
        public string? unit { get; set; }

        public WeatherModel(CurrentModel currentModel, LocationModel locationModel, RequestModel requestModel)
        {

            if (currentModel != null)
            {
                this.observation_time = currentModel.observation_time;
                this.temperature = currentModel.temperature;
                this.weather_description = currentModel.weather_descriptions[0];
                this.weather_icon = currentModel.weather_icons[0];
                this.name = locationModel.name;
                this.country = locationModel.country;
                this.type = requestModel.type;
                this.query = requestModel.query;
                this.unit = requestModel.unit;
            }

        }

        public WeatherModel()
        {
            
        }
    }
}
