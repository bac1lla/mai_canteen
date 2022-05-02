using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Categories, Schema = DbRoutes.Schema),
 Index(nameof(Name), IsUnique = true)]
public class Category : CanteenEntity, IEntity<Responses.Category.Get, Responses.Category.PartialGet>
{
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public virtual IEnumerable<Restaurant> Restaurants => Meals.Select(m => m.Restaurant).Distinct();

    public Responses.Category.Get Get() => new(this);
    public Responses.Category.PartialGet PartialGet() => new(this);
}