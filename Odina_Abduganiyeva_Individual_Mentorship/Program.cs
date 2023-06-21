using Odina_Abduganiyeva_Individual_Mentorship.BL.Services;

WeatherService weather = new WeatherService();

var city = Console.ReadLine();

await weather.GetWeatherInformation(city);