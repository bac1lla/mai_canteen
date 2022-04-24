using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.Restaurants)]
public record Restaurant : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; } = null;
    public string? PhotoLocation { get; set; } = null;

    // public int OrderCount { set; get; } = 0;
    // [Range(0, 5)] 
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Admin> Admins { get; set; } = new List<Admin>();
    // public List<Category> Categories { set; get; } = new();
    public virtual IEnumerable<Meal> Meals { get; set; } = new List<Meal>();
    public virtual  IEnumerable<Order> Orders { set; get; } = new List<Order>();
}