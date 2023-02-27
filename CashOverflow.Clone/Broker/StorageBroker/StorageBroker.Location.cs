using CashOverflow.Clone.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Clone.Broker.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Location> Locations { get; set; }
    }
}
