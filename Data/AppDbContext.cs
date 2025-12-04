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
                modelBuilder.Entity<OrderItem>()
                    .HasOne(oi => oi.MenuItem)
                    .WithMany(mi => mi.OrderItems)
                    .HasForeignKey(oi => oi.MenuItemId);

                modelBuilder.Entity<OrderItem>()
                    .HasOne(oi => oi.Order)
                    .WithMany(o => o.Items)
                    .HasForeignKey(oi => oi.OrderId);
            }

    
    }
}