using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
           builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.ShipAddress).IsRequired();
            builder.Property(x => x.ShipName).IsRequired();
            builder.Property(x => x.ShipEmail).IsRequired();
            builder.Property(x => x.ShipPhoneNumber).IsRequired();
            builder.Property(x => x.OrderDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.OrderStatus).IsRequired().HasDefaultValue(OrderStatus.Confirmed);
        }
    }
}
