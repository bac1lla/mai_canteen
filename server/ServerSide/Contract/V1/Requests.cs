namespace ServerSide.Contract.V1;

public static class Requests
{
    public static class Users
    {
        public record Get(string Id);
        // public record GetAll;
        public record Create(string Login, string Password, string? Name);
        public record Update(string Id, string? Name, string? Password);
        public record GetOrders(string Id);
    }

    public static class Admins
    {
        public record Get(string Id);
        public record Create(string Login, string Password, string Name);
        public record Update(string Id, string? Password, string? Name);
    }

    public static class SuperUser { }

    public static class Categories
    {
        public record Get(string Id);
        public record GetByName(string Name);
        public record Create(string Name, string? Description, string RestaurantId);
        public record Update(string Id, string? Name, string? Description);
        public record GetMeals(string Id);
        public record GetRestaurants(string Id);
    }
    
    public static class Restaurants
    {
        public record Get(string Id);
        public record GetByName(string Name);
        // TODO: PhotoLocation => Photo
        public record Create(string Name, string? Description, string? PhotoLocation);
        // TODO: PhotoLocation => Photo
        public record Update(string Id, string? Name, string? Description, string? PhotoLocation);
        public record GetAdmins(string Id);
        public record GetMeals(string Id);
        public record GetOrders(string Id);
    }

    public static class Meals
    {
        public record Get(string Id);
        public record GetByName(string Name);
        public record GetLikeName(string Name);
        // TODO: PhotoLocation => Photo
        public record Create(string Name, string? Ingredients, string? PhotoLocation, 
            string CategoryId, string RestaurantId);
        // TODO: PhotoLocation => Photo
        public record Update(string Id, string? Name, string? Ingredients,
            string? PhotoLocation, string CategoryId);
        public record GetCategory(string Id);
        public record GetRestaurant(string Id);
    }

    public static class Orders
    {
        public record Get(string Id);
        public record GetByDateTime(DateTime DateTime);
        public record Create(DateTime? CreationDate, List<string> MealIds, string? RestaurantId);
        public record Update(string Id, DateTime? CreationDate, List<string>? Meals, string? RestaurantId);
        public record GetMeals(string Id);
        public record GetRestaurant(string Id);
    }
} 