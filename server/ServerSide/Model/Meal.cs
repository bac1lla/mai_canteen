using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Meals, Schema = DbRoutes.Schema),
 Index(nameof(Name), IsUnique = false),
 Index(nameof(Category), IsUnique = false),
 Index(nameof(Restaurant), IsUnique = false)]
public class Meal : CanteenEntity
{
    public string Ingredients { init; get; }
    public bool IsInStopList { set; get; } = false;
    
    public virtual Category Category { init; get; }
    public virtual Restaurant Restaurant { init; get; }
    
    public virtual Price? CurrentPrice { set; get; }
    public virtual IEnumerable<Price> Prices { set; get; } = new List<Price>();

    public Meal(string name, string? description, string? photoLocation, 
        string ingredients, Category category, Restaurant restaurant, Price? currentPrice)
        : base(name, description, photoLocation)
    {
        Ingredients = ingredients;
        Category = category;
        Restaurant = restaurant;
        CurrentPrice = currentPrice;
        if (currentPrice is not null)
            Prices = new List<Price>() { currentPrice };
    }
    
    protected Meal(string name, string? description, string? photoLocation)
        : base(name, description, photoLocation)
    { }
}