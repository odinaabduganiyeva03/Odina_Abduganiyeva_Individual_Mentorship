using Newtonsoft.Json;
namespace Odina_Abduganiyeva_Individual_Mentorship.BL.Entities
{
    public class Weather
    {
        [JsonProperty("name")]
        public string CityName { get; set; }

        [JsonProperty("main")]
        public Temperature Temp { get; set; }
    }
}
