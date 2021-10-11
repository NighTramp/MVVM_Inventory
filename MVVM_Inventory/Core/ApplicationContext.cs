using System.Data.Entity;
using MVVM_Inventory.MVVM.Model;

namespace MVVM_Inventory.Core
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("MVVM_Inventory.Properties.Settings.DBIConnectionString") { }
    }
}
