using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Model;

[Table(DbRoutes.Restaurants)]
public class Restaurant : CanteenEntity
{
    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)] 
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Admin> Admins { get; set; } = new List<Admin>();
    // public List<Category> Categories { set; get; } = new();
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();
}