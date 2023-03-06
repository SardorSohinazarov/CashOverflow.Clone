using CashOverflow.Clone.Models.Locations.Exceptions;
using CashOverflow.Clone.Models.Locations;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public partial class LocationService
    {
        private static void ValidateLocationNotNull(Location location)
        {
            if (location is null)
                throw new NullLocationException();
        }
    }
}
