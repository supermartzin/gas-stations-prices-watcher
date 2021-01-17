using System.Collections.Generic;
using Geolocation;

namespace FuelPricesWatcher.Models
{
    public class FuelStation
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public Coordinate Coordinates { get; set; }

        public ISet<Fuel> FuelOfferings { get; set; }

        // add opening hours
    }
}