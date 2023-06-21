using Newtonsoft.Json;

namespace Odina_Abduganiyeva_Individual_Mentorship.BL.Entities
{
    public class Temperature
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}

