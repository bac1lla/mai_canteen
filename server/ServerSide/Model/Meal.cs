using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Meals, Schema = DbRoutes.Schema),
 Index(nameof(Name), IsUnique = false),
 Index(nameof(Category), IsUnique = false),
 Index(nameof(Restaurant), IsUnique = false)]
public class Meal : CanteenEntity, IEntity<Responses.Meal.Get, Responses.Meal.PartialGet>
{
    public string Ingredients { set; get; }
    
    public bool IsInStopList { set; get; } = false;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    // public int Version { set; get; } = 0;
    
    public Category Category { get; set; }
    
    public Restaurant Restaurant { set; get; }

    public Responses.Meal.Get Get() => new(this);
    public Responses.Meal.PartialGet PartialGet() => new (this);
}