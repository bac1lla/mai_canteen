namespace ServerSide.Models;

public class Meal
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string RestaurantId { set; get; }
    public string? PhotoLocation { get; set; } = null;
}