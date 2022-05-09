using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Model;

[Table(DbRoutes.Restaurants, Schema = DbRoutes.Schema)]
public class Restaurant : CanteenEntity, IEntity<Responses.Restaurant.Get, Responses.Restaurant.PartialGet>
{
    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)] 
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Admin> Admins { get; set; } = new List<Admin>();
    // public List<Category> Categories { set; get; } = new();
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();

    public Responses.Restaurant.Get Get() => new(this);
    public Responses.Restaurant.PartialGet PartialGet() => new(this);
}