using System;
using System.Linq;
using System.Threading.Tasks;

using FuelPricesWatcher.Models;

namespace FuelPricesWatcher.Services
{
    public class IbcUnistavBrnoFuelStationService : IFuelStationService
    {
        public FuelStation FuelStation { get; }

        public IbcUnistavBrnoFuelStationService(FuelStation fuelStation)
        {
            FuelStation = fuelStation ?? throw new ArgumentNullException(nameof(fuelStation));
        }

        public Task CheckForAllFuelPricesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task CheckForSpecificFuelPriceAsync(string fuelName)
        {
            if (fuelName == null)
                throw new ArgumentNullException(nameof(fuelName));

            // get specific fuel
            var fuel = FuelStation.FuelOfferings.FirstOrDefault(fuelOffer => fuelOffer.Name == fuelName);
            if (fuel == default)
                throw new ArgumentOutOfRangeException(nameof(fuelName), "Fuel station does not offer fuel with provided name.");
            
            // check for current price and update it in the fuel

            return Task.CompletedTask;
        }

        public Task CheckForSpecificFuelPriceAsync(FuelType fuelType)
        {
            // get all fuels with selected type
            var fuels = FuelStation.FuelOfferings.Where(fuelOffer => fuelOffer.Type == fuelType).ToList();
            if (fuels.Count == 0)
                throw new ArgumentOutOfRangeException(nameof(fuelType), $"Fuel station does not offer fuels of provided types.");

            // check for current prices and update it in all fuels

            return Task.CompletedTask;
        }
    }
}