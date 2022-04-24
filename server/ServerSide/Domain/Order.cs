using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using ServerSide.Contract.V1;

namespace ServerSide.Domain;

public record Order : BaseEntity
{
    [ComplexType]
    public class Item
    {
        public Meal Meal { set; get; }
        public ushort Count { set; get; }

        public Requests.Orders.Item.Get Get() => new(this);
    }
    
    // с названия кринжанул чето
    public DateTime? FulfillmentDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Item> Items { set; get; } = new List<Item>();
    
    public Restaurant Restaurant { get; set; }
    public User User { get; set; }
}