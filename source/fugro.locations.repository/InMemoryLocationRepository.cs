
using System.Collections.Generic;
using System.Linq;
using Fugro.Locations.Storage.Entity;

namespace Fugro.Locations.Storage
{
    public class InMemoryLocationRepository : IInMemoryLocationRepository
    {
        private readonly IDatabase _database;

        public InMemoryLocationRepository(IDatabase database)
        {
            _database = database;
        }


        private Location m_Location = new Location() { Id = 1, Latitude = 52.0000000d, Longitude = 4.0000000d };

        public IReadOnlyList<Location> GetLocation(int deviceId)
        {
            var devices = _database.Devices();
            var device = devices.FirstOrDefault(_ => _.Id == deviceId);
            return device != null ? device.Locations.ToList() : new List<Location>();
        }

        public void SetLocation(Location location) => m_Location = location;
    }
}
