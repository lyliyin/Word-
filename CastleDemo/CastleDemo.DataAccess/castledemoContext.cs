using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CastleDemo.DataAccess.Mapping;
using CastleDemo.Domain.Models;

namespace CastleDemo.DataAccess
{
    public partial class castledemoContext : DbContext
    {
        static castledemoContext()
        {
            Database.SetInitializer<castledemoContext>(null);
        }

        public castledemoContext()
            : base("Name=castledemoContext")
        {
        }

        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new productMap());
        }
    }
}
