namespace ServerSide.Contract.V1;

/// <summary>
/// Values-classes in request body for each type in domain
/// </summary>
public static class Requests
{
    public static class Base
    {
        public static class Entity
        {
            public abstract record Get(string Token)
            {
                protected Get() : this(string.Empty) { }
            }
            public abstract record Create : Get;
            public abstract record Update(DateTime? CreationDate = null) : Get;
            public abstract record Delete : Get;
        }
        
        public static class User
        {
            public abstract record Create(string Login, string Password, string Salt,
                string? Name = null) : Entity.Create
            {
                protected Create() : 
                    this(string.Empty, string.Empty, string.Empty, null)
                { }
            }
            public abstract record Update(string? Login = null, string? Name = null, string? Salt = null, 
                string? Password = null) : Entity.Update;
            public abstract record Authorize : Entity.Get;
        }

        public static class CanteenEntity
        {
            public abstract record Create(string Name, string? Description = null,
                string? PhotoLocation = null) : Entity.Create
            {
                protected Create() :
                    this(string.Empty, null, null)
                { }
            }
            public abstract record Update(string? Name = null, string? Description = null, 
                string? PhotoLocation = null) : Entity.Update;
        }
    }
    
    public static class SuperUser { }

    public static class Admin
    {
        public record Create(string RestaurantId) : Base.User.Create;
        public record Update(string? RestaurantId = null) : Base.User.Update;
    }
    
    public static class User { }

    public static class Category
    {
        public record Create(IEnumerable<string> MealIds) : Base.CanteenEntity.Create;
        public record Update(IEnumerable<string>? MealIds = null) : Base.CanteenEntity.Update;
    }
    
    public static class Restaurant
    {
        // TODO: PhotoLocation => Photo
        public record Create(IEnumerable<string> AdminIds, IEnumerable<string> MealIds) : Base.CanteenEntity.Create;
        // TODO: PhotoLocation => Photo
        public record Update(IEnumerable<string>? AdminIds = null, IEnumerable<string>? MealIds = null) : 
            Base.CanteenEntity.Update;
    }

    public static class Meal
    {
        // TODO: PhotoLocation => Photo
        public record Create(string? Ingredients, string CategoryId, string RestaurantId) : Base.CanteenEntity.Create;
        // TODO: PhotoLocation => Photo
        public record Update(string? Ingredients = null, string? CategoryId = null, string? RestaurantId = null) :
                Base.CanteenEntity.Update;
    }

    public static class Order
    {
        public record struct Item(string MealId, string UserId, ushort Count);
        public record Create(IEnumerable<Item> OrderItems, string RestaurantId, string UserId) : Base.Entity.Create;
        public record Update(IEnumerable<Item>? OrderItems = null, string? RestaurantId = null, 
            DateTime? FulfillmentDate = null) : Base.Entity.Update;
    }
} 