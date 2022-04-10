using System.ComponentModel.DataAnnotations;

namespace ServerSide.Models;

public class Meal
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string? PhotoLocation { get; set; } = null;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    // public int Version { set; get; } = 0;

    public Category Category { get; set; }
    public string CategoryId { get; set; }
    
    public Restaurant Restaurant { set; get; }
    public string ResaturantId { get; set; }
}