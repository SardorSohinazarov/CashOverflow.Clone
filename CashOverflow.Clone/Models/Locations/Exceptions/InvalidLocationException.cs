using Xeptions;

namespace CashOverflow.Clone.Models.Locations.Exceptions
{
    public class InvalidLocationException: Xeption
    {
        public InvalidLocationException() 
            :base(message:"Location is invalid")
        { }
    }
}
