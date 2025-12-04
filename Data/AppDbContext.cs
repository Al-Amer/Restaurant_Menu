using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Restaurant_Menu.Models;

namespace Restaurant_Menu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<MenuItem> MenuItems =>  Set<MenuItem>();
            public DbSet<Order> Orders => Set<Order>();
            public DbSet<OrderItem> OrderItems => Set<OrderItem>();
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }

    
    }
}