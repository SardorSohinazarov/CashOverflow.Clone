using Xeptions;

namespace CashOverflow.Clone.Models.Locations.Exceptions
{
    public class LocationValidationException:Xeption
    {
        public LocationValidationException(Xeption innerException)
            :base(message:"Location validation error occured, fix the error and try again")
        {}
    }
}
