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
            public abstract record Get;
            public abstract record Create;
            public abstract record Update(DateTime? CreationDate = null);
            public abstract record Delete;
        }
        
        public static class User
        {
            public abstract record Create(string Login, string Password, string Salt, 
                string? Name = null) : Entity.Create;
            public abstract record Update(string? Login = null, string? Name = null, string? Salt = null, 
                string? Password = null) : Entity.Update;

            public abstract record Authorize(string? Token, DateTime TokenCreationDate);
        }

        public static class CanteenEntity
        {
            public abstract record Create(string Name, string? Description = null, 
                string? PhotoLocation = null) : Entity.Create;
            public abstract record Update(string? Name = null, string? Description = null, 
                string? PhotoLocation = null) : Entity.Create;
        }
    }
    
    public static class SuperUser { }

    public static class Admin
    {
        public record Get;
        public record GetByRestaurant;
        
        public record Create : Base.Create;
        public record Update(string? Login, string? Password, string? Name);
        public record Delete;
    }
    
    public static class User
    {
        public record Get;

        public record Create : BaseUser.Create;
        public record Update : BaseUser.Update;
        public record Delete;

        public record GetOrders;
    }

    public static class Category
    {
        public record Get;
        public record GetByName;
        
        public record Create(string Name, string? Description, string? PhotoLocation, 
            IEnumerable<string> MealIds) : Base.Create;
        public record Update(string? Name, string? Description, string? PhotoLocation, 
            IEnumerable<string> MealIds);
        public record Delete;
        
        public record GetMeals;
        public record GetRestaurants;
    }
    
    public static class Restaurant
    {
        public record Get;
        public record GetByName;
        
        // TODO: PhotoLocation => Photo
        public record Create(string Name, string? Description, string? PhotoLocation, 
            IEnumerable<string> AdminIds, IEnumerable<string> MealIds) : Base.Create;
        // TODO: PhotoLocation => Photo
        public record Update(string? Name, string? Description, string? PhotoLocation, 
            IEnumerable<string> AdminIds, IEnumerable<string> MealIds);
        public record Delete;
        
        public record GetAdmins;
        public record GetMeals;
        public record GetOrders;
    }

    public static class Meal
    {
        public record Get;
        public record GetByName;
        public record GetLikeName;
        
        // TODO: PhotoLocation => Photo
        public record Create(string Name, string? Ingredients, string? PhotoLocation, 
            string CategoryId, string RestaurantId) : Base.Create;
        // TODO: PhotoLocation => Photo
        public record Update(string? Name, string? Ingredients, string? PhotoLocation, 
            string? CategoryId, string? RestaurantId);
        public record Delete;
        
        // TODO: do we need this?
        public record GetCategory;
        // TODO: do we need this?
        public record GetRestaurant;
    }

    public static class Orders
    {
        public record struct OrderItem(string MealId, ushort Count);
        
        public record Get;
        public record GetByDateTime;
        public record GetByUser;
        
        public record Create(IEnumerable<OrderItem> OrderItems, string RestaurantId, string UserId) : Base.Create;
        public record Update(IEnumerable<OrderItem>? OrderItems, string? RestaurantId, 
            DateTime? FulfillmentDate);
        
        public record GetMeals;
        public record GetRestaurant;
        public record GetUser;
    }
} 