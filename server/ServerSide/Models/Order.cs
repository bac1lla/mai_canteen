using System.ComponentModel.DataAnnotations;

namespace ServerSide.Models;

public class Order : BaseEntity
{
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { get; set; } = DateTime.Now;
    // с названия кринжанул чето
    [DataType(DataType.DateTime)]
    public DateTime? FulfillmentDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    // public List<Meal> Meals { set; get; } = new();
    
    public Restaurant Restaurant { get; set; }
    // public string RestaurantId { get; set; }
}