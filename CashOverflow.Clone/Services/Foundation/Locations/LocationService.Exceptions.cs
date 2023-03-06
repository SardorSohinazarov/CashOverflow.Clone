// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System.Threading.Tasks;
using CashOverflow.Clone.Models.Locations;
using CashOverflow.Clone.Models.Locations.Exceptions;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public partial class LocationService
    {
        private delegate ValueTask<Location> ReturningLocationFunction()
        private async ValueTask<Location> TryCatch(ReturningLocationFunction returningLocationFunction)
        {
            try
            {
                return await returningLocationFunction();
            }
            catch (NullLocationException nullLocationException)
            {
                LocationValidationException locationValidationException = CreateAndLogValidationException(nullLocationException);

                throw locationValidationException;
            }
        }

        private LocationValidationException CreateAndLogValidationException(NullLocationException nullLocationException)
        {
            var locationValidationException = new LocationValidationException(nullLocationException);
            this.loggingBroker.LogError(locationValidationException);
            return locationValidationException;
        }
    }
}
