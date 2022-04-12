namespace ServerSide.Models;

public class Restaurant
{
    public string Name { get; set; }
    public string? Description { get; set; } = null;
    public string? PhotoLocation { get; set; } = null;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)] 
    // public decimal? Score { set; get; } = null;
    
    public List<Admin> Admins { get; set; } = new();

    // public List<Category> Categories { set; get; } = new();
    public List<Meal> Meals { get; set; } = new();
    
    public List<Order> Orders { set; get; } = new();
}