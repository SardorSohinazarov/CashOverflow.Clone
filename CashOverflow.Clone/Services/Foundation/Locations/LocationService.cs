﻿using System.Threading.Tasks;
using CashOverflow.Clone.Broker.StorageBroker;
using CashOverflow.Clone.Models.Locations;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public class LocationService : ILocationService
    {
        private IStorageBroker storageBroker;

        public LocationService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public ValueTask<Location> AddLocationAsync(Location location) =>
            throw new System.NotImplementedException();
    }
}
