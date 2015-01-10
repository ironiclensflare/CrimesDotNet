using Newtonsoft.Json;

namespace CrimesDotNet
{
    public class CrimeDataset
    {
        [JsonProperty("date")]
        public string Date { get; set; }
    }
}
