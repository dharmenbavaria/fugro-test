using Newtonsoft.Json;

namespace Fugro.Locations.Dto
{

    public sealed class Location
    {
        [JsonConstructor]
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; }

        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; }
    }
}
