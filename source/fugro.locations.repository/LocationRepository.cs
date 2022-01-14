using Fugro.Locations.Dto;

namespace Fugro.Locations.Repository
{
    public sealed class LocationRepository
    {
        private Location m_Location = new(52.0d, 4.0d);

        public Location GetLocation() => m_Location;

        public void SetLocation(Location location) => m_Location = location;
    }
}
