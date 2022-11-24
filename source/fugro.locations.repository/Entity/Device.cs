using System.Collections.Generic;

namespace Fugro.Locations.Storage.Entity
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IList<Location> Locations { get; set; } = new List<Location>();
    }
}
