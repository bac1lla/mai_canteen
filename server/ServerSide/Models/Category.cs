namespace ServerSide.Models;

public class Category
{
    public string Name { set; get; }
    public string? Description { get; set; }
    public string? PhotoLocation { get; set; }

    public List<Meal> Meals { get; set; } = new();
    // public List<Restaurant> Restaurants { get; set; } = new();
}