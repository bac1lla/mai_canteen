using ServerSide.Models;

namespace ServerSide.Contract.V1;

public static class Responses
{
    public static class Users
    {
        // TODO: decide what info to expose about users
        public record Get(string Login, string? Name, List<string> OrderIds, DateTime CreationDate);
        // public record GetAll(List<Get> Users);
        public record Create(string Id);
        public record Update;
        public record GetOrders(List<Orders.Get> OrderIds);
    }

    public static class Admins
    {
        // TODO: decide what info to expose about admins
        public record Get(string Login, string Name, string RestaurantId, DateTime CreationDate);
        public record Create(string Id);
        public record Update;
    }

    public static class SuperUser { }

    public static class Categories
    {
        // TODO: PhotoLocation => Photo
        public record Get(string Name, string? Description, string? PhotoLocation, 
            List<string> MealIds, DateTime CreationDate);
        // TODO: PhotoLocation => Photo
        public record GetByName(List<GetByName.Item> Items)
        {
            public record Item(string Id, string? Description, string? PhotoLocation, 
                List<string> MealIds, DateTime CreationDate);
        }
        public record Create(string Id);
        public record Update;
        public record GetMeals(List<Meals.Get> Meals);
        public record GetRestaurants(List<Restaurants.Get> Restaurants);
    }
    
    public static class Restaurants
    {
        // TODO: PhotoLocation => Photo
        public record Get(string Name, string? Description, string? PhotoLocation, 
            List<string> AdminIds, List<string> MealIds, List<string> OrderIds, DateTime CreationDate);
        // TODO: PhotoLocation => Photo
        public record GetByName(List<GetByName.Item> Items)
        {
            public record Item(string Id, string? Description, string? PhotoLocation,
                List<string> AdminIds, List<string> MealIds, List<string> OrderIds, DateTime CreationDate);
        }
        public record Create(string Id);
        public record Update;
        public record GetAdmins(List<Admins.Get> Admins);
        public record GetMeals(List<Meals.Get> Meals);
        public record GetOrders(List<Orders.Get> Orders);
    }

    public static class Meals
    {
        // TODO: PhotoLocation => Photo
        public record Get(string Name, string? Ingredients, string? PhotoLocation, 
            string CategoryId, string RestaurantId, DateTime CreationDate);
        // TODO: PhotoLocation => Photo
        public record GetByName(List<GetByName.Item> Items)
        {
            public record Item(string Id, string? Ingredients, string? PhotoLocation,
                string CategoryId, string RestaurantId, DateTime CreationDate);
        }
        // TODO: PhotoLocation => Photo
        public record GetLikeName(List<GetLikeName.Item> Items)
        {
            public record Item(string Id, string? Ingredients, string? PhotoLocation,
                string CategoryId, string RestaurantId, DateTime CreationDate);
        }
        public record Create(string Id);
        public record Update;
        public record GetCategory(Categories.Get Category);
        public record GetRestaurant(Restaurants.Get Restaurants);
    }

    public static class Orders
    {
        public record Get(List<string> MealIds, string RestaurantId, DateTime? FulfillmentDate, DateTime CreationDate);
        public record GetByDateTime(List<GetByDateTime.Item> Items)
        {
            public record Item(List<string> MealIds, string RestaurantId, DateTime? FulfillmentDate);
        }
        public record Create(string Id);
        public record Update;
        public record GetMeals(List<Meals.Get> Meals);
        public record GetRestaurant(Restaurants.Get Restaurant);
    }
}