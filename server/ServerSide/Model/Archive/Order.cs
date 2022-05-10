using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Orders, Schema = DbRoutes.Archive.Schema),
 Index(nameof(CreationDate), IsUnique = false),
 Index(nameof(UserId), IsUnique = false),
 Index(nameof(RestaurantId), IsUnique = false),
 Index(nameof(EndDate), IsUnique = false)]
public class Order : BaseEntity
{
    [ComplexType]
    public record IntermediateItem(string OrderId, string MealId, ushort Count)
    {
        public override string ToString() => JsonSerializer.Serialize(this);

        // public override string ToString() => new StringBuilder()
        //     .Append('{')
        //     .Append("\"Id\":").Append(Id).Append(',')
        //     .Append("\"MealId\":").Append(MealId).Append(',')
        //     .Append("\"Count\":").Append(Count)
        //     .Append('}')
        //     .ToString();д
    }
    
    public DateTime EndDate { init; get; }
    
    public bool IsAccepted { init; get; }
    public bool IsRejected { init; get; } 
    public bool IsReady { init; get; }
    public bool IsCanceled { init; get; } 
    
    public string RestaurantId { init; get; }
    public string UserId { init; get; }
    
    public string ItemsString { init; get; }

    private static IEnumerable<IntermediateItem> TransformItems(IEnumerable<Model.Order.Item> items) =>
        items.Select(i => new IntermediateItem(i.OrderId, i.MealId, i.Count));
    
    private static string GetItemsString(IEnumerable<Model.Order.Item> items) => new StringBuilder()
            .Append('[').AppendJoin(',', TransformItems(items)).Append(']')
            .ToString();
    
    private Order
    (
        string id,
        DateTime creationDate,
        bool isDeleted,
        DateTime endDate,
        bool isAccepted,
        bool isRejected,
        bool isReady,
        bool isCanceled,
        string restaurantId,  
        string userId,
        string itemsString
    ) 
        : base(id, creationDate, isDeleted)
    {
        EndDate = endDate;
        IsAccepted = isAccepted;
        IsRejected = isRejected;
        IsReady = isReady;
        IsCanceled = isCanceled;
        RestaurantId = restaurantId;
        UserId = userId;
        ItemsString = itemsString;
    }

    public static Order FromNewOrder(Model.Order order) =>
        new(
            order.Id, 
            order.CreationDate, 
            order.IsDeleted, 
            order.EndDate!.Value,
            order.IsAccepted,
            order.IsRejected,
            order.IsReady,
            order.IsCanceled,
            order.Restaurant.Id,
            order.User.Id,
            GetItemsString(order.Items)
        ); 
    
}