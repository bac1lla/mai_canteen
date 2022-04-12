using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerSide.Models;

public class Order : BaseEntity
{
    [ComplexType]
    public class Item
    {
        public Meal Meal { set; get; }
        public ushort Count { set; get; }
    }
    
    // с названия кринжанул чето
    public DateTime? FulfillmentDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    public List<Item> Items { set; get; } = new();
    
    public Restaurant Restaurant { get; set; }
    public string RestaurantId { get; set; }
}