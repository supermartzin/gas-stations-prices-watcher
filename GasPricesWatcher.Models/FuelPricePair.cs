using System;

namespace GasPricesWatcher.Models
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