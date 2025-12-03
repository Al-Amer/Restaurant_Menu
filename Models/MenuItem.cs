namespace Restaurant_Menu.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}