using System;
using System.Collections.Generic;
using Geolocation;

namespace FuelPricesWatcher.Models
{
    public class FuelStation
    {
        private readonly ISet<Fuel> _fuels;
        private readonly ISet<PaymentType> _paymentOptions;

        public string Name { get; }

        public string Address { get; }

        public Coordinate Location { get; }

        public ISet<Fuel> FuelOfferings => new HashSet<Fuel>(_fuels);

        public ISet<PaymentType> PaymentOptions => new HashSet<PaymentType>(_paymentOptions);

        public string WebsiteUrl { get; }

        public bool HasCarWash { get; }

        public bool OffersRefreshments { get; }

        public bool IsSelfService { get; }

        public bool HasToilets { get; }

        // add opening hours

        public FuelStation(string name,
                           string address,
                           Coordinate location,
                           ISet<Fuel> fuelOfferings,
                           ISet<PaymentType> paymentOptions,
                           string websiteUrl = null,
                           bool hasCarWash = false,
                           bool offersRefreshments = false,
                           bool isSelfService = false,
                           bool hasToilets = false)
        {
            Name = name;
            Address = address;
            Location = location;
            WebsiteUrl = websiteUrl;
            HasCarWash = hasCarWash;
            OffersRefreshments = offersRefreshments;
            IsSelfService = isSelfService;
            HasToilets = hasToilets;

            _fuels = new HashSet<Fuel>(
                fuelOfferings ?? throw new ArgumentNullException(nameof(fuelOfferings)));
            _paymentOptions = new HashSet<PaymentType>(
                paymentOptions ?? throw new ArgumentNullException(nameof(paymentOptions)));
        }
    }
}