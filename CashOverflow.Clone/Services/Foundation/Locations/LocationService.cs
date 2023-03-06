using System.Threading.Tasks;
using CashOverflow.Clone.Broker.Loggings;
using CashOverflow.Clone.Broker.StorageBroker;
using CashOverflow.Clone.Models.Locations;
using CashOverflow.Clone.Models.Locations.Exceptions;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public partial class LocationService : ILocationService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public LocationService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;

        public LocationService(
            IStorageBroker storageBroker, 
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Location> AddLocationAsync(Location location)
        {
            try
            {
                ValidateLocationNotNull(location);

                return await this.storageBroker.InsertLocationAsync(location);
            }
            catch (NullLocationException nullLocationException)
            {
                var locationValidationException = new LocationValidationException(nullLocationException);
                this.loggingBroker.LogError(locationValidationException);

                throw locationValidationException;
            }
        }
    }
}
