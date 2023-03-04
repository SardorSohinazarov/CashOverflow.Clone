using System.Threading.Tasks;
using CashOverflow.Clone.Models.Locations;
using Microsoft.Data.SqlClient.DataClassification;

namespace CashOverflow.Clone.Broker.StorageBroker
{
    public partial interface IStorageBroker
    {
        ValueTask<Location> InsertLocationAsync(Location location);
    }
}
