﻿using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace eShop.Data.Configurations
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.OrderId });
            builder.ToTable("OrderDetails");
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);


        }
    }
}