using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DoudouMons.Core;

namespace DoudouMons.DAL
{
    public class DoudouContext : DbContext
    {
        internal object Character;

        public DoudouContext() : base("DoudouContext")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public object Characters { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}