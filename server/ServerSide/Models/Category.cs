namespace ServerSide.Models;

public class Category
{
    private static ulong _lastId = 0;
    public ulong Id { get; set; } = ++_lastId;

    public string Name { set; get; }
    public string Description { get; set; }

    public List<Meal> Meals { get; set; } = new();
    // public List<Restaurant> Restaurants { get; set; } = new();
}