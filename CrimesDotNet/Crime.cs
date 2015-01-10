using Newtonsoft.Json;

namespace CrimesDotNet
{
    public class Crime
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("persistent_id")]
        public string PersistentId { get; set; }

        [JsonProperty("location_type")]
        public LocationType LocationType { get; set; }

        [JsonProperty("location_subtype")]
        public string LocationSubtype { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("outcome_status")]
        public OutcomeStatus OutcomeStatus { get; set; }
    }

    public class Location
    {
        [JsonProperty("latitude")]
        public double Lat { get; set; }

        [JsonProperty("longitude")]
        public double Lng { get; set; }

        [JsonProperty("street")]
        public Street Street { get; set; }
    }

    public class Street
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OutcomeStatus
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public enum LocationType
    {
        Force,
        BTP
    }
}
