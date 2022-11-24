using System.Collections.Generic;
using Fugro.Locations.Storage;
using Fugro.Locations.Storage.Entity;
using Moq;
using Xunit;

namespace Fugro.Locations.Services.Tests
{
    public class LocationServiceTests
    {
        [Fact]
        public void GetLocationsOfDevice_ValidDeviceLocationData_ProvidesValidLocations()
        {
            var locations = new List<Location>()
            {
                new Location() { Id = 1, Latitude = 52.0000000d, Longitude = 4.0000000d }
            };
            var deviceId = 1;
            var locationService = SetupMock(deviceId, locations);
            var locationsOfDevice = locationService.GetLocationsOfDevice(1);
            Assert.NotNull(locationsOfDevice);
            Assert.Equal(1, locationsOfDevice.Count);
            Assert.Equal(52.0000000d, locationsOfDevice[0].Latitude);

        }

        [Fact]
        public void GetLocationsOfDevice_InValidDeviceLocationData_ProvidesEmptyLocationList()
        {
            var locations = new List<Location>()
            {
            };
            var deviceId = 1;
            var locationService = SetupMock(deviceId, locations);
            var locationsOfDevice = locationService.GetLocationsOfDevice(1);
            Assert.NotNull(locationsOfDevice);
            Assert.Equal(0, locationsOfDevice.Count);

        }

        private static ILocationService SetupMock(int deviceId, List<Location> locations)
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            var mockLocationRepository = mockRepository.Create<IInMemoryLocationRepository>();

            mockLocationRepository.Setup(p => p.GetLocation(deviceId)).Returns(locations);
            var locationService = new LocationService(mockLocationRepository.Object);
            return locationService;
        }
    }
}
