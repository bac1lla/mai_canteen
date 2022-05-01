using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Model;

[Table(DbRoutes.Categories)]
public class Category : CanteenEntity
{
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public virtual IEnumerable<Restaurant> Restaurants => Meals.Select(m => m.Restaurant).Distinct();

    // public Requests.Category.Get Get() => new(this);
}