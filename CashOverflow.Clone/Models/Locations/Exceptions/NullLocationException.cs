using Xeptions;

namespace CashOverflow.Clone.Models.Locations.Exceptions
{
    public class NullLocationException : Xeption
    {
        public NullLocationException()
            :base(message:"Location is null")
        {}
    }
}
