using System;

namespace FuelPricesWatcher.Models
{
    public class FuelPricePair
    {
        public DateTime Time { get; }

        public decimal Price { get; }

        public FuelPricePair(DateTime time, decimal price)
        {
            Time = time;
            Price = price;
        }
    }
}