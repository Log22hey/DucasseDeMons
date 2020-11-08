using DoudouMons.Core;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DoudouMons.DAL
{
    public class DoudouContext : DbContext
    {

        public DoudouContext() : base("DoudouContext")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}