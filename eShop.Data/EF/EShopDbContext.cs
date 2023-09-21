using eShon.Data.Entities;
using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.EF
{
    public class EShopDbContext:DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart>Cart { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<CategoryTranslation> CategoriesTranslation { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }   
        public DbSet<ProductTranslation> ProductTranslations { get; set; }  
        public DbSet<Promotion> Promotion { get; set; } 
        public DbSet<Transaction> Transaction { get; set; }
       

    }
}
