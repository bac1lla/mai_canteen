using System.ComponentModel.DataAnnotations;

namespace ServerSide.Models;

public class Order : BaseEntity
{
    public DateTime CreationDate { get; set; } = DateTime.Now;
    // с названия кринжанул чето
    public DateTime? FulfillmentDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    public List<Meal> Meals { set; get; } = new();
    
    public Restaurant Restaurant { get; set; }
    public string RestaurantId { get; set; }
}