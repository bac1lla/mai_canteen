using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Orders),
 Index(nameof(CreationDate)),
 Index(nameof(UserId)),
 Index(nameof(RestaurantId)),
 Index(nameof(EndDate))]
public class Order : BaseEntity
{
    [ComplexType]
    public record IntermediateItem(string Id, string MealId, ushort Count)
    {
        // public override string ToString() => new StringBuilder()
        //     .Append('{')
        //     .Append("\"Id\":").Append(Id).Append(',')
        //     .Append("\"MealId\":").Append(MealId).Append(',')
        //     .Append("\"Count\":").Append(Count)
        //     .Append('}')
        //     .ToString();
    }

    public string ItemsString { init; get; }
    public string UserId { init; get; }
    public string RestaurantId { init; get; }
    public DateTime EndDate { init; get; }
    
    private static string GetItemsString(IEnumerable<IntermediateItem> items) => new StringBuilder()
            .Append('[').AppendJoin(',', items).Append(']')
            .ToString();
    
    private Order
    (
        string id,
        DateTime creationDate,
        bool isDeleted,
        string itemsString, 
        string userId, 
        string restaurantId, 
        DateTime endDate
    ) 
        : base(id, creationDate, isDeleted)
    {
        ItemsString = itemsString;
        UserId = userId;
        RestaurantId = restaurantId;
        EndDate = endDate;
    }

    public static Order FromNewOrder(Model.Order order) =>
        new(
            order.Id, 
            order.CreationDate, 
            order.IsDeleted, 
            GetItemsString(order.Items.Select(i => new IntermediateItem(i.Id, i.Meal.Id, i.Count))), 
            order.User.Id, 
            order.Restaurant.Id, 
            order.EndDate!.Value // only finished orders are archived
        ); 
    
}