using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ServerSide.Models;

[Index(nameof(Name), Name = "Names")]
public class Meal
{
    public string Name { get; set; }
    public string? Ingredients { get; set; } = null;
    public string? PhotoLocation { get; set; } = null;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    // public int Version { set; get; } = 0;
    
    public decimal Price { set; get; }
    
    public Category Category { get; set; }
    // public string CategoryId { get; set; }
    
    public Restaurant Restaurant { set; get; }
    // public string ResaturantId { get; set; }
}