using Microsoft.EntityFrameworkCore;
using Restaurant_Menu.Models;

namespace Restaurant_Menu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    
    }
}