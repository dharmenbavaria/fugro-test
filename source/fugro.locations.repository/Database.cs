using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fugro.Locations.Storage.Entity;

namespace Fugro.Locations.Storage
{
    public class Database : IDatabase
    {

        public IList<Device> Devices()
        {
            return new List<Device>()
            {
                new Device()
                {
                    Id = 1, Name = "A", Locations = new List<Location>()
                    {
                        new Location() { Id = 1, Latitude = 52.0000000d, Longitude = 4.0000000d }
                    }
                }
            };
        }
    }
}
