using System;
using System.Collections.Generic;


namespace eShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlias { get; set; }
        public List<Order> Order { get; set; } 
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductInCategory> ProductInCategory { get; set; }

    }
}
