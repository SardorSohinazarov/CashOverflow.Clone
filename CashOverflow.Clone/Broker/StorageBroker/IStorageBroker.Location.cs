using System.Reflection.Emit;
using System.Threading.Tasks;
using CashOverflow.Clone.Models.Locations;

namespace CashOverflow.Clone.Broker.StorageBroker
{
    public partial interface IStorageBroker
    {
        ValueTask<Location> InsertLocationAsync(Location location);
    }
}
