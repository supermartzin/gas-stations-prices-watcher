using System.Threading.Tasks;

using FuelPricesWatcher.Models;

namespace FuelPricesWatcher.Services
{
    public interface IFuelStationService
    {
        FuelStation FuelStation { get; }

        Task CheckForAllFuelPricesAsync();

        Task CheckForSpecificFuelPriceAsync(string fuelName);

        Task CheckForSpecificFuelPriceAsync(FuelType fuelType);
    }
}
