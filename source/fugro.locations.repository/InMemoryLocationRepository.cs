using Fugro.Locations.Dto;

namespace Fugro.Locations.Storage
{
    public sealed class InMemoryLocationRepository
    {
        private Location m_Location = new(52.0000000d, 4.0000000d);

        public Location GetLocation() => m_Location;

        public void SetLocation(Location location) => m_Location = location;
    }
}
