using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DoudouMons.Core;

namespace DoudouMons.DAL
{
    public class DoudouContext : DbContext
    {
        public DoudouContext() : base("DoudouContext")
        {
        }

        public DbSet<Character> Students { get; set; }
        public DbSet<Weapon> Enrollments { get; set; }
        public DbSet<Role> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}