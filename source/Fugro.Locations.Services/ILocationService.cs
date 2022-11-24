using Fugro.Locations.Dto;

namespace Fugro.Locations.Services;

public interface ILocationService
{
    IReadOnlyList<Location> GetLocationsOfDevice(int deviceId);
}