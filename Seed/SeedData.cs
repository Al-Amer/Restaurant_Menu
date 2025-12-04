using Restaurant_Menu.Models;
using Restaurant_Menu.Data;

namespace Restaurant_Menu.Seed
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.MenuItems.Any())
            {
                return; // DB has been seeded
            }

            var menuItems = new List<MenuItem>
            {
                new MenuItem { Name = "Margherita Pizza" , Category="Pizza", Description = "Tomatoes, mozzarella, and basil", Price = 8.99m },
                new MenuItem { Name = "Caesar Salad", Category="Salad", Description = "Crisp romaine lettuce with Caesar dressing, croutons, and Parmesan cheese", Price = 6.49m },
                new MenuItem { Name = "Spaghetti Carbonara", Category="Pasta", Description = "Pasta with eggs, cheese, pancetta, and pepper", Price = 10.99m },
                new MenuItem { Name = "Grilled Chicken Sandwich", Category="Sides", Description = "Grilled chicken breast with lettuce, tomato, and mayo on a bun", Price = 7.99m },
                new MenuItem { Name="Margherita Pizza", Category="Pizza", Price=8.50m, Description="Tomato, mozzarella" },
                new MenuItem { Name="Pepperoni Pizza", Category="Pizza", Price=9.50m, Description="Pepperoni & cheese" },
                new MenuItem { Name="Caesar Salad", Category="Salad", Price=6.00m, Description="Romaine, parmesan" },
                new MenuItem { Name="Spaghetti Bolognese", Category="Pasta", Price=10.00m, Description="Beef ragu" },
                new MenuItem { Name="Minestrone Soup", Category="Soup", Price=5.00m, Description="Veggie soup" },
                new MenuItem { Name="Tiramisu", Category="Dessert", Price=4.50m, Description="Coffee dessert" },
                new MenuItem { Name="Lemonade", Category="Drink", Price=2.50m, Description="Fresh-squeezed" },
                new MenuItem { Name="Garlic Bread", Category="Sides", Price=3.00m, Description="Toasted with garlic" }
            };
            // seeded data into the database
            context.MenuItems.AddRange(menuItems);
            context.SaveChanges();
        }
    }
}