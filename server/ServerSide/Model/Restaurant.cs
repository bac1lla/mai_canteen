using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Model;

[Table(DbRoutes.Restaurants, Schema = DbRoutes.Schema)]
public class Restaurant : CanteenEntity
{
    public virtual IEnumerable<Admin> Admins { set; get; } = new List<Admin>();
    public virtual IEnumerable<Meal> Meals { set; get; } = new List<Meal>();
    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();

    public Restaurant(string name, string? description, string? photoLocation) 
        : base(name, description, photoLocation)
    { }
}