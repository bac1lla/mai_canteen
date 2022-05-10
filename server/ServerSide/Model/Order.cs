using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Model;

// [Index(nameof(User))] // TODO: may be slow
[Table(DbRoutes.Orders, Schema = DbRoutes.Schema)]
public class Order : BaseEntity
{
    [Table(DbRoutes.OrderItems, Schema = DbRoutes.Schema)]
    public class Item
    {
        public virtual Order Order { init; get; }
        public string OrderId { init; get; }
        
        public virtual Meal Meal { init; get; }
        public string MealId { init; get; }
        
        public ushort Count { init; get; }

        public Item(Order order, Meal meal, ushort count)
        {
            Order = order;
            OrderId = order.Id;
            Meal = meal;
            MealId = meal.Id;
            Count = count;
        }
        
        protected Item() { }
    }
    
    public DateTime? EndDate { get; set; } = null;

    public bool IsAccepted { set; get; } = false;
    public bool IsRejected { set; get; } = false;
    public bool IsReady { set; get; } = false;
    public bool IsCanceled { set; get; } = false;

    public virtual IEnumerable<Item> Items { set; get; }
    
    public virtual Restaurant Restaurant { get; init; }
    public virtual User User { get; init; }

    public Order(IEnumerable<Item> items, Restaurant restaurant, User user)
        : base()
    {
        Items = items;
        Restaurant = restaurant;
        User = user;
    }
    
    protected Order() : base() { }
}