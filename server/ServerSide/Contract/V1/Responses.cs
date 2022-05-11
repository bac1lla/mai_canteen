using System.Text.Json.Serialization;
using ServerSide.Model;
using ServerSide.Model.ModelExtensions;
using Helpers = ServerSide.Model.ModelExtensions.ModelHelpersAndBasicExtensions;

namespace ServerSide.Contract.V1;

public static class Responses
{
    public static class Base
    {
        public static class Entity
        {
            public abstract class Get : Model.BaseEntity
            {
                protected Get(Model.BaseEntity entity) : 
                    base(entity.Id, entity.CreationDate, entity.IsDeleted)
                { } 
            }

            public abstract class PartialGet
            {
                public string Id { init; get; }
                public PartialGet(Model.BaseEntity entity) => Id = entity.Id;
            }

            public class Create
            {
                public string Id { init; get; }
                public Create(Model.BaseEntity entity) => Id = entity.Id;
            }

            public record Update;
            public record Delete;
        }

        public static class User
        {
            public class Get : Base.Entity.Get
            {
                public string Login { init; get; }
                public string? Name { init; get; }
                public bool IsBanned { init; get; }
                public string? TokenValue { init; get; }
                
                public Get(Model.BaseUser user) : base(user)
                {
                    Login = user.Login;
                    Name = user.Name;
                    IsBanned = user.IsBanned;
                    TokenValue = user.TokenValue;
                }
            }
            
            public class PartialGet : Base.Entity.PartialGet
            {
                public string Login { init; get; }
                public string? Name { init; get; }
                public bool IsBanned { init; get; }
                public string? TokenValue { init; get; }
                
                public PartialGet(Model.BaseUser user) : base(user)
                {
                    Login = user.Login;
                    Name = user.Name;
                    IsBanned = user.IsBanned;
                    TokenValue = user.TokenValue;
                }
            }

            public abstract record Authorize(string Token);
        }

        public static class CanteenEntity
        {
            public abstract class Get : Base.Entity.Get
            {
                public string Name { init; get; }
                public string? Description { init; get; }
                public string? PhotoLocation { init; get; }
                
                protected Get(Model.CanteenEntity canteenEntity) : base(canteenEntity)
                {
                    Name = canteenEntity.Name;
                    Description = canteenEntity.Description;
                    PhotoLocation = canteenEntity.PhotoLocation;
                }
            }
            
            public abstract class PartialGet : Base.Entity.PartialGet
            {
                public string Name { init; get; }
                public string? Description { init; get; }
                public string? PhotoLocation { init; get; }
                
                protected PartialGet(Model.CanteenEntity canteenEntity) : base(canteenEntity)
                {
                    Name = canteenEntity.Name;
                    Description = canteenEntity.Description;
                    PhotoLocation = canteenEntity.PhotoLocation;
                }
            }
        }
    }

    public static class User
    {
        // TODO: decide what info to expose about users
        public class Get : Base.User.Get
        {
            public IEnumerable<Order.PartialGet> Orders { init; get; }
            public Get(Model.User user) : base(user) => 
                Orders = user.Orders.Select(o => o.PartialGet());
        }
        
        // TODO: decide what info to expose about users
        public class PartialGet : Base.User.PartialGet
        {
            public IEnumerable<string> OrderIds { init; get; }
            public PartialGet(Model.User user) : base(user) => 
                OrderIds = Helpers.IdsOnly(user.Orders);
        }

        // public class GetAll
        // {
        //     public IEnumerable<User.Get> Users { init; get; }
        //     public GetAll(IEnumerable<Model.User> users) => Users = users.Select(u => u.Get());
        // }

        public record GetOrders(IEnumerable<Order.PartialGet> Orders)
        {
            public GetOrders(IEnumerable<Model.Order> orders) : 
                this(orders.Select(o => o.PartialGet()))
            { }
        }
    }

    public static class Admin
    {
        // TODO: decide what info to expose about admins
        public class Get : Base.User.Get
        {
            public Restaurant.PartialGet Restaurant { init; get; }
            public Get(Model.Admin admin) : base(admin) => Restaurant = admin.Restaurant.PartialGet();
        }
        
        // TODO: decide what info to expose about admins
        public class PartialGet : Base.User.PartialGet
        {
            public string RestaurantId { init; get; }
            public PartialGet(Model.Admin admin) : base(admin) => RestaurantId = admin.Restaurant.Id;
        }

        public record GetByRestaurant(IEnumerable<PartialGet> Admins)
        {
            public GetByRestaurant(IEnumerable<Model.Admin> admins) :
                this(admins.Select(a => a.PartialGet()))
            { }
        }
    }

    public static class SuperUser { }

    public static class Category
    {
        // TODO: PhotoLocation => Photo
        public class Get : Responses.Base.CanteenEntity.Get
        {
            public IEnumerable<Meal.PartialGet> Meals { init; get; }
            public Get(Model.Category category) : base(category) => 
                Meals = category.Meals.Select(m => m.PartialGet());
        }
        // TODO: PhotoLocation => Photo
        public class PartialGet : Responses.Base.CanteenEntity.PartialGet
        {
            public IEnumerable<string> MealIds { init; get; }
            public PartialGet(Model.Category category) : base(category) => 
                MealIds = Helpers.IdsOnly(category.Meals);
        }
        
        public record GetAll(IEnumerable<PartialGet> Categories)
        {
            public GetAll(IEnumerable<Model.Category> categories) :
                this(categories.Select(c => c.PartialGet()))
            { }
        }
        // TODO: PhotoLocation => Photo
        public record GetByName(IEnumerable<PartialGet> Categories)
        {
            public GetByName(IEnumerable<Model.Category> categories) 
                : this(categories.Select(c => c.PartialGet()))
            { }
        }
        
        public record GetMeals(IEnumerable<Meal.Get> Meals)
        {
            public GetMeals(IEnumerable<Model.Meal> meals) 
                : this(meals.Select(m => m.Get()))
            { }
        }
        // public class GetRestaurants(IEnumerable<Restaurant.Get> Restaurants);
    }
    
    public static class Restaurant
    {
        // TODO: PhotoLocation => Photo
        public class Get : Responses.Base.CanteenEntity.Get
        {
            public IEnumerable<Admin.PartialGet> Admins { init; get; }
            public IEnumerable<Meal.PartialGet> Meals { init; get; }

            public Get(Model.Restaurant restaurant) : base(restaurant)
            {
                Admins = restaurant.Admins.Select(a => a.PartialGet());
                Meals = restaurant.Meals.Select(m => m.PartialGet());
            }
        }
        // TODO: PhotoLocation => Photo
        public class PartialGet : Responses.Base.CanteenEntity.PartialGet
        {
            public IEnumerable<string> AdminIds { init; get; }
            public IEnumerable<string> MealIds { init; get; }

            public PartialGet(Model.Restaurant restaurant) : base(restaurant)
            {
                AdminIds = Helpers.IdsOnly(restaurant.Admins);
                MealIds = Helpers.IdsOnly(restaurant.Meals);
            }
        }

        public record GetAll(IEnumerable<PartialGet> Restaurants)
        {
            public GetAll(IEnumerable<Model.Restaurant> restaurants) :
                this(restaurants.Select(r => r.PartialGet()))
            { }
        }
        // TODO: PhotoLocation => Photo
        public record GetByName(IEnumerable<Get> Restaurants)
        {
            public GetByName(IEnumerable<Model.Restaurant> restaurants)
                : this(restaurants.Select(r => r.Get()))
            { }
        }

        public record GetAdmins(IEnumerable<Admin.Get> Admins)
        {
            public GetAdmins(IEnumerable<Model.Admin> admins) :
                this(admins.Select(a => a.Get()))
            { }
        }
        public record GetMeals(IEnumerable<Meal.Get> Meals)
        {
            public GetMeals(IEnumerable<Model.Meal> meals) :
                this(meals.Select(m => m.Get()))
            { }
        }
        public record GetOrders(IEnumerable<Order.Get> Orders)
        {
            public GetOrders(IEnumerable<Model.Order> orders) :
                this(orders.Select(o => o.Get()))
            { }
        }
    }

    public static class Price
    {
        public class Get : Base.Entity.Get
        {
            public decimal Value { init; get; }
            public DateTime? InvalidationDate { init; get; }
            public Meal.PartialGet Meal { init; get; }

            public Get(Model.Price price) : base(price)
            {
                Value = price.Value;
                InvalidationDate = price.InvalidationTime;
                Meal = price.Meal.PartialGet();
            }
        }
        
        public class PartialGet : Base.Entity.PartialGet
        {
            public decimal Value { init; get; }
            public DateTime? InvalidationDate { init; get; }
            public string MealId { init; get; }

            public PartialGet(Model.Price price) : base(price)
            {
                Value = price.Value;
                InvalidationDate = price.InvalidationTime;
                MealId = price.Meal.Id;
            }
        }
    }
    
    public static class Meal
    {
        // TODO: PhotoLocation => Photo
        public class Get : Base.CanteenEntity.Get
        {
            public string Ingredients { init; get; }
            public Category.PartialGet Category { init; get; }
            public Restaurant.PartialGet Restaurant { init; get; }
            public Price.PartialGet? CurrentPrice { init; get; }

            public Get(Model.Meal meal) : base(meal)
            {
                Ingredients = meal.Ingredients;
                Category = meal.Category.PartialGet();
                Restaurant = meal.Restaurant.PartialGet();
                CurrentPrice = meal.CurrentPrice?.PartialGet();
            }
        }
        // TODO: PhotoLocation => Photo
        public class PartialGet : Base.CanteenEntity.PartialGet
        {
            public string Ingredients { init; get; }
            public string CategoryId { init; get; }
            public string RestaurantId { init; get; }
            public string? PriceId { init; get; }

            public PartialGet(Model.Meal meal) : base(meal)
            {
                Ingredients = meal.Ingredients;
                CategoryId = meal.Category.Id;
                RestaurantId = meal.Restaurant.Id;
                PriceId = meal.CurrentPrice?.Id;
            }
        }

        public record GetAll(IEnumerable<Get> Meals)
        {
            public GetAll(IEnumerable<Model.Meal> meals) :
                this(meals.Select(m => m.Get()))
            { }
        }

        public record GetCategory(Category.Get Category)
        {
            public GetCategory(Model.Category category) :
                this(category.Get())
            { }
        }
        public record GetRestaurant(Restaurant.Get Restaurants)
        {
            public GetRestaurant(Model.Restaurant restaurant) :
                this(restaurant.Get())
            { }
        }
    }

    public static class Order
    {
        public record struct Item(string MealId, string OrderId, ushort Count)
        {
            public Item(Model.Order.Item item) : 
                this(item.Meal.Id, item.Order.Id, item.Count) 
            { }
        }

        public class Get : Base.Entity.Get
        {
            public DateTime? EndDate { init; get; }
            
            public bool IsAccepted { init; get; }
            public bool IsRejected { init; get; } 
            public bool IsReady { init; get; }
            public bool IsCanceled { init; get; } 
            
            public Restaurant.PartialGet Restaurant { init; get; }
            public User.PartialGet User { init; get; }
            
            public IEnumerable<Item> Items { init; get; }

            public Get(Model.Order order) : base(order)
            {
                EndDate = order.EndDate;

                IsAccepted = order.IsAccepted;
                IsRejected = order.IsRejected;
                IsReady = order.IsReady;
                IsCanceled = order.IsCanceled;
                
                User = order.User.PartialGet();
                Restaurant = order.Restaurant.PartialGet();

                Items = order.Items.Select(i => i.Get());
            }
        }
        public class PartialGet : Base.Entity.Get
        {
            public DateTime? EndDate { init; get; }
            
            public bool IsAccepted { init; get; }
            public bool IsRejected { init; get; } 
            public bool IsReady { init; get; }
            public bool IsCanceled { init; get; } 
            
            public string RestaurantId { init; get; }
            public string UserId { init; get; }

            public IEnumerable<Item> Items { init; get; }
            
            public PartialGet(Model.Order order) : base(order)
            {
                EndDate = order.EndDate;
                
                IsAccepted = order.IsAccepted;
                IsRejected = order.IsRejected;
                IsReady = order.IsReady;
                IsCanceled = order.IsCanceled;
                
                RestaurantId = order.Restaurant.Id;
                UserId = order.User.Id;
                
                Items = order.Items.Select(i => i.Get());
            }
        }

        public record GetByUser(IEnumerable<PartialGet> Orders)
        {
            public GetByUser(IEnumerable<Model.Order> orders) :
                this(orders.Select(o => o.PartialGet()))
            { }
        }
        
        public record GetMeals(IEnumerable<Meal.Get> Meals)
        {
            public GetMeals(IEnumerable<Model.Meal> meals) :
                this(meals.Select(m => m.Get()))
            { }
        }
        
        public record GetUser(User.Get User)
        {
            public GetUser(Model.User user) : 
                this(user.Get())
            { }
        }
        public record GetRestaurant(Restaurant.Get Restaurant)
        {
            public GetRestaurant(Model.Restaurant restaurant) : 
                this(restaurant.Get())
            { }
        }
    }
}