using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Configurations
{
    internal class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductInCategory).HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.Category).WithMany(pc => pc.ProductInCategory).HasForeignKey(p => p.CategoryId);
        }
    }
}
