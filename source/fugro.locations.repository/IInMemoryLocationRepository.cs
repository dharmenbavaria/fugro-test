using System.Collections.Generic;
using Fugro.Locations.Storage.Entity;

namespace Fugro.Locations.Storage;

public interface IInMemoryLocationRepository
{
    IReadOnlyList<Location> GetLocation(int deviceId);
    void SetLocation(Location location);
}