using Fugro.Locations.Dto;
using Fugro.Locations.Storage;

namespace Fugro.Locations.Services
{
    public class LocationService : ILocationService
    {
        private readonly IInMemoryLocationRepository _inMemoryLocationRepository;

        public LocationService(IInMemoryLocationRepository inMemoryLocationRepository)
        {
            _inMemoryLocationRepository = inMemoryLocationRepository;
        }

        public IReadOnlyList<Location> GetLocationsOfDevice(int deviceId)
        {
            return _inMemoryLocationRepository.GetLocation(deviceId).Select(_ => new Location(_.Latitude, _.Longitude))
                .ToList();
        }
    }
}

namespace Fugro.Locations.Services
{
}