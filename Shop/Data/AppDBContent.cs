using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions options) : base(options) 
        { 
        
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }

    }
}
