

using DoudouMons.Core;
using DoudouMons.Core.models;
using DoudouMons.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DoudouMons.Infrastructure.DAL
{
    public class DoudouContext : DbContext
    {

        public DoudouContext() : base("DoudouContext")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shopping> Shoppings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}