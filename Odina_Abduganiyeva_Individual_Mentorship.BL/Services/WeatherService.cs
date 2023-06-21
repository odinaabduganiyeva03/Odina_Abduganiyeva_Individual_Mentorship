using Newtonsoft.Json;
using Odina_Abduganiyeva_Individual_Mentorship.BL.Entities;
using Odina_Abduganiyeva_Individual_Mentorship.BL.Interfaces;

namespace Odina_Abduganiyeva_Individual_Mentorship.BL.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task GetWeatherInformation(string city)
        {
            double formula = 273.15;
            var client = new HttpClient();
            var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=8c56ad334221a918a20e93f8b7d516f0");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var weather = JsonConvert.DeserializeObject<Weather>(json);
                var tempOfCity = Math.Round(weather.Temp.Temp - formula);

                if (tempOfCity < 0)
                    Console.WriteLine(weather.CityName + " --> " + tempOfCity + " " + "Dress warmly");
                if (tempOfCity <= 20)
                    Console.WriteLine(weather.CityName + " --> " + tempOfCity + " " + "It's fresh");
                if (tempOfCity > 20)
                    if (tempOfCity <= 30)
                        Console.WriteLine(weather.CityName + " --> " + tempOfCity + " " + "Good weather");
                if (tempOfCity > 30)
                    Console.WriteLine(weather.CityName + " --> " + tempOfCity + " " + "It's to go to the beach =<");
            }

            else
                Console.WriteLine("City not found");

        }
    }
}
