using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.Models;
using FoodOrder.ViewModels;

namespace FoodOrdering.DBAccess
{
    public class DbConnection : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
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