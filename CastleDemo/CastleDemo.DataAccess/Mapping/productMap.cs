using CastleDemo.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CastleDemo.DataAccess.Mapping
{
    public class productMap : EntityTypeConfiguration<Product>
    {
        public productMap()
        {
            // Primary Key
            this.HasKey(t => t.productId);

            // Properties
            this.Property(t => t.productId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.productName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("products", "castledemo");
            this.Property(t => t.productId).HasColumnName("productId");
            this.Property(t => t.productName).HasColumnName("productName");
        }
    }
}
