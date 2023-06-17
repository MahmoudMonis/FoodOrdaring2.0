using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.Models;
using FoodOrder.ViewModels;

namespace FoodOrdering.DBAccess
{
    public class DbConnection : DbContext
    {
<<<<<<< HEAD
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
=======
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("host=localhost;port=5432;dbname=postgres;user=postgres;password=123456;sslmode=prefer;connect_timeout=10");
        
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
         public DbSet<FoodItem> Items { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        
>>>>>>> e5deb05fd106671b926db696d501229127bfe545
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;port=5432;Database=FoodOrdering;Username=postgres;Password=123093;IncludeErrorDetail=true;");
        }
    }
}