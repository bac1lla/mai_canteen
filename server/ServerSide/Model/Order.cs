using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Model;

// [Index(nameof(User))] // TODO: may be slow
[Table(DbRoutes.Orders)]
public class Order : BaseEntity
{
    [Table(DbRoutes.OrderItems)]
    public class Item
    {
        [Key]
        public string Id { set; get; }
        
        public Order Order { init; get; }
        public Meal Meal { init; get; }
        public ushort Count { set; get; } = 1;
    
        public Responses.Order.Item Get() => new(this);
    }
    
    public DateTime? EndDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Item> Items { set; get; } = new List<Item>();
    
    public Restaurant Restaurant { get; set; }
    
    // public Admin? Admin { set; get; } = null;
    
    public User User { get; set; }
}