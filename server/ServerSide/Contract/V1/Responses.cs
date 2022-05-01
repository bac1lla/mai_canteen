using ServerSide.Model;

namespace ServerSide.Contract.V1;

public static class Responses
{
    public static class Base
    {
        public static class Entity
        {
            public abstract class Get
            {
                public DateTime CreationDate { set; get; }
                public bool IsDeleted { set; get; }

                protected Get(BaseEntity baseEntity)
                {
                    CreationDate = baseEntity.CreationDate;
                    IsDeleted = baseEntity.IsDeleted;
                }
            }

            public record Create(string Id)
            {
                public Create(BaseEntity baseEntity) : this(baseEntity.Id) { }
            }

            public record Delete;
            public record Update;
        }

        public static class User
        {
            public abstract class Get : Base.Entity.Get
            {
                public string Login { set; get; }
                public string? Name { set; get; }

                protected Get(BaseUser baseUser) : base(baseUser)
                {
                    Login = baseUser.Login;
                    Name = baseUser.Name;
                }
            }
        }

        public static class CanteenEntity
        {
            public abstract class Get : Entity.Get
            {
                public string Name { set; get; }
                public string? Description { set; get; }
                public string? PhotoLocation { set; get; }
                
                protected Get(Model.CanteenEntity canteenEntity) : base(canteenEntity)
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
            public IEnumerable<Order.Get> Orders { set; get; }

            public Get(Model.User user) : base(user) => 
                Orders = user.Orders.Select(o => new Order.Get(o));
        }

        public record GetAll(IEnumerable<Get> Users)
        {
            public GetAll(IEnumerable<Model.User> users) : 
                this(users.Select(u => new User.Get(u))) 
            { }
        }

        public record GetOrders(IEnumerable<Order.Get> Orders)
        {
            public GetOrders(IEnumerable<Model.Order> orders) : 
                this(orders.Select(o => new Order.Get(o)))
            { }
        }
    }

    public static class Admin
    {
        // TODO: decide what info to expose about admins
        public class Get : Base.User.Get
        {
            public Restaurant.Get Restaurant { set; get; }
            
            public Get(Model.Admin admin) : base(admin) => 
                Restaurant = new Restaurant.Get(admin.Restaurant);
        }

        public record GetByRestaurant(IEnumerable<Get> Admins)
        {
            public GetByRestaurant(IEnumerable<Model.Admin> admins) 
                : this(admins.Select(a => new Get(a)))
            { }
        }
    }

    public static class SuperUser { }

    public static class Category
    {
        // TODO: PhotoLocation => Photo
        public class Get : Responses.Base.CanteenEntity.Get
        {
            public IEnumerable<Meal.Get> Meals { set; get; }

            public Get(Model.Category category) : base(category) => 
                Meals = category.Meals.Select(m => new Meal.Get(m));
        }
        // TODO: PhotoLocation => Photo
        public record GetByName(IEnumerable<Get> Categories)
        {
            public GetByName(IEnumerable<Model.Category> categories) 
                : this(categories.Select(c => new Get(c))) 
            { }
        }

        public record GetMeals(IEnumerable<Meal.Get> Meals)
        {
            public GetMeals(IEnumerable<Model.Meal> meals) 
                : this(meals.Select(m => new Meal.Get(m)))
            { }
        }
        // public record GetRestaurants(IEnumerable<Restaurant.Get> Restaurants);
    }
    
    public static class Restaurant
    {
        // TODO: PhotoLocation => Photo
        public class Get : Responses.Base.CanteenEntity.Get
        {
            public IEnumerable<Admin.Get> Admins { set; get; }
            public IEnumerable<Meal.Get> Meals { set; get; }

            public Get(Model.Restaurant restaurant) : base(restaurant)
            {
                Admins = restaurant.Admins.Select(a => new Admin.Get(a));
                Meals = restaurant.Meals.Select(m => new Meal.Get(m));
            }
        }
        // TODO: PhotoLocation => Photo
        public record GetByName(IEnumerable<Get> Restaurants)
        {
            public GetByName(IEnumerable<Model.Restaurant> restaurants)
                : this(restaurants.Select(r => new Get(r)))
            { }
        }
        
        // public class GetAdmins(IEnumerable<Admin.Get> Admins);
        // public class GetMeals(IEnumerable<Meal.Get> Meals);
        // public class GetOrders(IEnumerable<Order.Get> Orders);
    }

    public static class Meal
    {
        // TODO: PhotoLocation => Photo
        public class Get : Base.CanteenEntity.Get
        {
            public string Ingredients { set; get; }
            public Category.Get Category { set; get; }
            public Restaurant.Get Restaurant { set; get; }

            public Get(Model.Meal meal) : base(meal)
            {
                Ingredients = meal.Ingredients;
                Category = new Category.Get(meal.Category);
                Restaurant = new Restaurant.Get(meal.Restaurant);
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
        public record struct Item(string MealId, ushort Count)
        {
            public Item(Model.Order.Item item) : this(item.Meal.Id, item.Count) { }
        }

        public class Get : Base.Entity.Get
        {
            public IEnumerable<Item> Items { set; get; }
            public Restaurant.Get Restaurant { set; get; }
            public DateTime? EndDate { set; get; }

            public Get(Model.Order order) : base(order)
            {
                Items = order.Items.Select(i => i.Get());
                Restaurant = new Restaurant.Get(order.Restaurant);
                EndDate = order.EndDate;
            }
        }
        
        // public class GetByDateTime(IEnumerable<Get> Orders);
        //
        // public class GetMeals(IEnumerable<Meal.Get> Meals);
        // public class GetRestaurant(Restaurant.Get Restaurant);
    }
}