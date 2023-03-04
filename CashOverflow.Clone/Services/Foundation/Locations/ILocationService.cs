using System.Threading.Tasks;
using CashOverflow.Clone.Models.Locations;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public interface ILocationService
    {
        ValueTask<Location> AddLocationAsync(Location location);
    }
}
