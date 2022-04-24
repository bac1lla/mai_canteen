namespace ServerSide.Contract.V1;

/// <summary>
/// Values-classes in request body for each type in domain
/// </summary>
public static class Requests
{
    public static class Base
    {
        public record Create(DateTime? CreationDate)
        {
            /// Never should be called
            public Create() : this((DateTime?) null) => throw new NotImplementedException();
        }
        
        public record Update(DateTime? CreationDate)
        {
            /// Never should be called
            public Update() : this((DateTime?) null) => throw new NotImplementedException();
        }
    }
    
    public static class BaseUser
    {
        public record Create(string Login, string? Name, string Password) : Base.Create
        {
            /// Never should be called
            public Create() : this(string.Empty, null, string.Empty) => throw new NotImplementedException();
        }
        
        public record Update(string? Login, string? Name, string? Password) : Base.Create
        {
            /// Never should be called
            public Update() : this(null, null, null) => throw new NotImplementedException();
        }
    }
    
    public static class User
    {
        public record Get;

        public record Create : BaseUser.Create;
        public record Update : BaseUser.Update;
        public record Delete;

        public record GetOrders;
    }

    public static class Admin
    {
        public record Get;
        public record GetByRestaurant;
        
        public record Create : Base.Create;
        public record Update(string? Login, string? Password, string? Name);
        public record Delete;
    }

    public static class SuperUser { }

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