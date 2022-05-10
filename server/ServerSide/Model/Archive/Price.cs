using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Prices, Schema = DbRoutes.Archive.Schema),
 Index(nameof(MealId), IsUnique = false)]
public class Price : BaseEntity
{
    [Precision(16, 2)]
    public decimal Value { init; get; }

    public DateTime InvalidationTime { init; get; } = DateTime.Now;
    
    public string MealId { init; get; }

    public Price(Model.Price price)
        : base()
    {
        Value = price.Value;
        MealId = price.Meal.Id;
    }
    
    protected Price() { }
}