using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.Meals),
 Index(nameof(Name))]
public record Meal : BaseEntity
{
    public string Name { get; set; }
    public string? Ingredients { get; set; } = null;
    public string? PhotoLocation { get; set; } = null;

    public bool IsInStopList { set; get; } = false;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    // public int Version { set; get; } = 0;
    
    public Category Category { get; set; }
    public Restaurant Restaurant { set; get; }

    public Requests.Meal.Get Get() => new(this);
}