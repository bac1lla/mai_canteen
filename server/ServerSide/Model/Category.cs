using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Categories, Schema = DbRoutes.Schema),
 Index(nameof(Name), IsUnique = true)]
public class Category : CanteenEntity
{
    public virtual IEnumerable<Meal> Meals { set; get; } = new List<Meal>();
    
    public Category(string name, string? description, string? photoLocation)
        : base(name, description, photoLocation)
    { }
}