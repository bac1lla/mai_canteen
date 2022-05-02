using System.Text.Json.Serialization;
using ServerSide.Model;

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

            public abstract class Create
            {
                public string Id { init; get; }
                protected Create(Model.BaseEntity entity) => Id = entity.Id;
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
                
                public Get(Model.BaseUser user) : base(user)
                {
                    Login = user.Login;
                    Name = user.Name;
                }
            }
            
            public class PartialGet : Base.Entity.PartialGet
            {
                public string Login { init; get; }
                public string? Name { init; get; }
                
                public PartialGet(Model.BaseUser user) : base(user)
                {
                    Login = user.Login;
                    Name = user.Name;
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

    public static class Token
    {
        public class Get : Base.Entity.Get
        {
            [JsonIgnore] 
            private new string Id { init; get; } = string.Empty;
            
            public string Value { init; get; }
            public Base.User.PartialGet User { init; get; }
            public DateTime ExpirationDate { init; get; }
            public bool IsValid { init; get; }
            
            public Get(Model.Token token) : base(token)
            {
                Value = token.Value;
                User = token.User.PartialGet();
                ExpirationDate = token.ExpirationDate;
                IsValid = token.IsValid;
            }
        }
        
        public class PartialGet : Base.Entity.PartialGet
        {
            [JsonIgnore] 
            private new string Id { init; get; } = string.Empty;
            
            public string Value { init; get; }
            public string UserId { init; get; }
            public DateTime ExpirationDate { init; get; }
            public bool IsValid { init; get; }
            
            public PartialGet(Model.Token token) : base(token)
            {
                Value = token.Value;
                UserId = token.User.Id;
                ExpirationDate = token.ExpirationDate;
                IsValid = token.IsValid;
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
                OrderIds = BaseEntity.IdsOnly(user.Orders);
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
        public class PartialGet : Base.User.Get
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
                MealIds = Model.BaseEntity.IdsOnly(category.Meals);
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
        public class PartialGet : Responses.Base.CanteenEntity.Get
        {
            public IEnumerable<string> AdminIds { init; get; }
            public IEnumerable<string> MealIds { init; get; }

            public PartialGet(Model.Restaurant restaurant) : base(restaurant)
            {
                AdminIds = Model.BaseEntity.IdsOnly(restaurant.Admins);
                MealIds = Model.BaseEntity.IdsOnly(restaurant.Meals);
            }
        }
        
        // TODO: PhotoLocation => Photo
        public record GetByName(IEnumerable<Get> Restaurants)
        {
            public GetByName(IEnumerable<Model.Restaurant> restaurants)
                : this(restaurants.Select(r => r.Get()))
            { }
        }
        
        // public class GetAdmins(IEnumerable<Admin.Get> Admins);
        public record GetMeals(IEnumerable<Meal.Get> Meals)
        {
            public GetMeals(IEnumerable<Model.Meal> meals) :
                this(meals.Select(m => m.Get()))
            { }
        }
        // public class GetOrders(IEnumerable<Order.Get> Orders);
    }

    public static class Meal
    {
        // TODO: PhotoLocation => Photo
        public class Get : Base.CanteenEntity.Get
        {
            public string Ingredients { init; get; }
            public Category.PartialGet Category { init; get; }
            public Restaurant.PartialGet Restaurant { init; get; }

            public Get(Model.Meal meal) : base(meal)
            {
                Ingredients = meal.Ingredients;
                Category = meal.Category.PartialGet();
                Restaurant = meal.Restaurant.PartialGet();
            }
        }
        // TODO: PhotoLocation => Photo
        public class PartialGet : Base.CanteenEntity.Get
        {
            public string Ingredients { init; get; }
            public string CategoryId { init; get; }
            public string RestaurantId { init; get; }

            public PartialGet(Model.Meal meal) : base(meal)
            {
                Ingredients = meal.Ingredients;
                CategoryId = meal.Category.Id;
                RestaurantId = meal.Restaurant.Id;
            }
        }
        
        // TODO: PhotoLocation => Photo
        // public class GetByName(IEnumerable<Get> Meals);
        // // TODO: PhotoLocation => Photo
        // public class GetLikeName(IEnumerable<Get> Meals);
        
        // public class GetCategory(Category.Get Category);
        // public class GetRestaurant(Restaurant.Get Restaurants);
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
            public IEnumerable<Item> Items { init; get; }
            public User.PartialGet User { init; get; }
            public Restaurant.PartialGet Restaurant { init; get; }
            public DateTime? EndDate { init; get; }

            public Get(Model.Order order) : base(order)
            {
                Items = order.Items.Select(i => i.Get());
                User = order.User.PartialGet();
                Restaurant = order.Restaurant.PartialGet();
                EndDate = order.EndDate;
            }
        }
        
        public class PartialGet : Base.Entity.Get
        {
            public IEnumerable<Item> Items { init; get; }
            public string UserId { init; get; }
            public string RestaurantId { init; get; }
            public DateTime? EndDate { init; get; }

            public PartialGet(Model.Order order) : base(order)
            {
                Items = order.Items.Select(i => i.Get());
                UserId = order.User.Id;
                RestaurantId = order.Restaurant.Id;
                EndDate = order.EndDate;
            }
        }
        
        // public class GetByDateTime(IEnumerable<Get> Orders);
        //
        // public class GetMeals(IEnumerable<Meal.Get> Meals);
        // public class GetRestaurant(Restaurant.Get Restaurant);
    }
}