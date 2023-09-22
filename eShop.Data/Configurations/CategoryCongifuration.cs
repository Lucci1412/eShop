using eShop.Data.Entities;
using eShop.Data.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace eShop.Data.Configurations
{
    internal class CategoryCongifuration : IEntityTypeConfiguration<Category>
    {
      

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categorys");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.IsShowOnHome).IsRequired().HasDefaultValue(false);
        }
    }
}
