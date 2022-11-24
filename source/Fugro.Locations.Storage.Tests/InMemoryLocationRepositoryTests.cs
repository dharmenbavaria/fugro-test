using System.Collections.Generic;
using System.Linq;
using Fugro.Locations.Storage.Entity;
using Moq;
using Xunit;

namespace Fugro.Locations.Storage.Tests
{
    public class InMemoryLocationRepositoryTests
    {
        [Fact]
        public void GetLocation_WithValidDevice_ProvidesDeviceLocations()
        {
            var devices = new List<Device>()
            {
                new Device()
                {
                    Id = 1, Name = "A", Locations = new List<Location>()
                    {
                        new Location() { Id = 1, Latitude = 52.0000000d, Longitude = 4.0000000d }
                    }
                }
            };
            var inMemoryLocationRepository = SetupMock(devices);

            var locations = inMemoryLocationRepository.GetLocation(1);

            Assert.NotNull(locations);
            Assert.Equal(1, locations.Count);
            Assert.Equal(1, locations[0].Id);
        }

        [Fact]
        public void GetLocation_WithInValidDevice_ProvidesEmptyLocations()
        {
            var devices = new List<Device>()
            {
                new Device()
                {
                    Id = 1, Name = "A", Locations = new List<Location>()
                    {
                        new Location() { Id = 1, Latitude = 52.0000000d, Longitude = 4.0000000d }
                    }
                }
            };
            var inMemoryLocationRepository = SetupMock(devices);

            var locations = inMemoryLocationRepository.GetLocation(2);

            Assert.NotNull(locations);
            Assert.Equal(0, locations.Count);
        }

        private static IInMemoryLocationRepository SetupMock(List<Device> devices)
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            var mockDatabase = mockRepository.Create<IDatabase>();

            mockDatabase.Setup(p => p.Devices()).Returns(devices);
            var inMemoryLocationRepository = new InMemoryLocationRepository(mockDatabase.Object);
            return inMemoryLocationRepository;
        }
    }
}