using System.Collections.Generic;
using Fugro.Locations.Storage.Entity;

namespace Fugro.Locations.Storage;

public interface IDatabase
{
    IList<Device> Devices();
}