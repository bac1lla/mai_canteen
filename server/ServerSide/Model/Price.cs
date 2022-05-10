using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Prices, Schema = DbRoutes.Schema)]
public class Price : BaseEntity
{
    [Precision(16, 2)]
    public decimal Value { init; get; }

    public DateTime? InvalidationTime { set; get; } = null;
    
    public virtual Meal Meal { init; get; }
    public string MealId { init; get; }

    public Price(decimal value, Meal meal)
        : base()
    {
        Value = value;
        Meal = meal;
        MealId = Meal.Id;
    }
    
    protected Price() : base() { }
}