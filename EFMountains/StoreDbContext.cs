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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ComplexType<Contact>();
        }

        public IDbSet<Order> Orders { get; set; }
    }
}