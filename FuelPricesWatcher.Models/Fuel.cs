using System.Collections.Generic;

namespace FuelPricesWatcher.Models
{
    public class Fuel
    {
        private readonly IList<FuelPricePair> _historicPrices;

        public FuelType Type { get; }

        public string Name { get; }

        public FuelPricePair CurrentPrice { get; private set; }

        public IList<FuelPricePair> HistoricPrices => new List<FuelPricePair>(_historicPrices);

        public Fuel(FuelType type, string name, FuelPricePair currentPrice)
        {
            Type = type;
            Name = name;
            CurrentPrice = currentPrice;

            _historicPrices = new List<FuelPricePair>();
        }
    }
}