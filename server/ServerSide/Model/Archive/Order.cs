using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Orders),
 Index(nameof(User)),
 Index(nameof(Restaurant)),
 Index(nameof(CreationDate)),
 Index(nameof(EndDate))]
public class Order : Model.Order
{
    [Table(DbRoutes.Archive.OrderItems),
     Index(nameof(User)),
     Index(nameof(Meal))]
    public new class Item : Model.Order.Item
    {
        public Item(Model.Order.Item item)
        {
            Id = item.Id;
            Meal = item.Meal;
            Order = item.Order;
            Count = item.Count;
        }
    }
    
    public new virtual IEnumerable<Item> Items { init; get; }

    public Order(Model.Order order)
    {
        Id = order.Id;
        User = order.User;
        Restaurant = order.Restaurant;
        IsDeleted = order.IsDeleted;
        CreationDate = order.CreationDate;
        EndDate = order.EndDate;
        Items = order.Items.Select(i => new Item(i));
    }
}