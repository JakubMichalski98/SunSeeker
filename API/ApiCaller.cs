using SunSeeker.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace SunSeeker.API
{
    public class ApiCaller
    {
        public async Task<WeatherModel> MakeCall(string location)
        {
            //ApiInitializer.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("access_key", "3c74ad19f2d49b6c71ca3a8aa17d9295");

            var response = await ApiInitializer.httpClient.GetAsync($"http://api.weatherstack.com/current?access_key=3c74ad19f2d49b6c71ca3a8aa17d9295&query={location}");

            var responseString = await response.Content.ReadAsStringAsync();

            WeatherResponseModel? responseModel = JsonSerializer.Deserialize<WeatherResponseModel>(responseString);

            WeatherModel? weatherModel = new(responseModel.current, responseModel.location, responseModel.request);

            return weatherModel;

        }
    }
}
