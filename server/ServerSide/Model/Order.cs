using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.Arm;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

// [Index(nameof(User))] // TODO: may be slow
[Table(DbRoutes.Orders, Schema = DbRoutes.Schema)]
public class Order : BaseEntity, IGetEntity<Responses.Order.Get>
{
    [Table(DbRoutes.OrderItems, Schema = DbRoutes.Schema)]
    public class Item
    {
        public Order Order { init; get; }
        public Meal Meal { init; get; }
        public ushort Count { set; get; }

        public Item(Order order, Meal meal, ushort count = 1)
        {
            Order = order;
            Meal = meal;
            Count = count;
        }
        
        public Responses.Order.Item Get() => new(this);
    }
    
    public DateTime? EndDate { get; set; } = null;
    
    // [Range(0, 5)]
    // public decimal? Score { set; get; } = null;
    
    public virtual IEnumerable<Item> Items { set; get; } = new List<Item>();
    
    public Restaurant Restaurant { get; set; }
    
    // public Admin? Admin { set; get; } = null;
    
    public User User { get; set; }

    public Responses.Order.Get Get() => new(this);
    public Responses.Order.PartialGet PartialGet() => new(this);

    // public void Add(Meal meal)
    // {
    //     var item = Items.FirstOrDefault(i => i.Meal == meal);
    //     if (item is null)
    //     {
    //         var items = new List<Item>(Items);
    //         items.Add(new Item(this, meal));
    //         Items = items;
    //     }
    //     else item.Count += 1;
    // }
    //
    // public void Remove(Meal meal) => 
    //     Items = new List<Item>(Items.Where(i => i.Meal != meal));
    //
    // public void RemoveOne(Meal meal) 
    // {
    //     var item = Items.FirstOrDefault(i => i.Meal == meal);
    //     if (item is not null)
    //         item.Count -= 1;
    // }
}