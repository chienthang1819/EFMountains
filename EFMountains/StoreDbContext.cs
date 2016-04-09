using System.Configuration;
using System.Data.Entity;
using EFMountains.Domain;

namespace EFMountains
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext()
            : this("StoreConnection")
        {
        }

        public StoreDbContext(string connectionName)
            : base(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString)
        {

        }

        public IDbSet<Order> Orders { get; set; }
    }
}