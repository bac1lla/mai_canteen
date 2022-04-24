using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.Categories),
 Index(nameof(Name))]
public record Category(string Name, string? Description = null, string? PhotoLocation = null) : BaseEntity
{
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public IEnumerable<Restaurant> Restaurants => Meals.Select(m => m.Restaurant).Distinct();

    public Requests.Category.Get Get() => new(this);
}