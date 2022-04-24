using ServerSide.Domain;

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

                protected Get(Domain.BaseEntity baseEntity)
                {
                    CreationDate = baseEntity.CreationDate;
                    IsDeleted = baseEntity.IsDeleted;
                }
            }

            public record Create(string Id)
            {
                public Create(Domain.BaseEntity baseEntity) : this(baseEntity.Id) { }
            }
        }

        public static class User
        {
            public abstract class Get : Base.Entity.Get
            {
                public string Login { set; get; }
                public string? Name { set; get; }

                protected Get(Domain.BaseUser baseUser) : base(baseUser)
                {
                    Login = baseUser.Login;
                    Name = baseUser.Name;
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

            public Get(Domain.User user) : base(user) => 
                Orders = user.Orders.Select(o => new Order.Get(o));
        }

        public record GetAll(IEnumerable<Get> Users)
        {
            public GetAll(IEnumerable<Domain.User> users) : 
                this(users.Select(u => new User.Get(u))) 
            { }
        }
        public record Create(string Id);
        public record Update;
        public record Delete;

        public record GetOrders(IEnumerable<Order.Get> Orders)
        {
            public GetOrders(IEnumerable<Domain.Order> orders) : 
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
            
            public Get(Domain.Admin admin) : base(admin) => 
                Restaurant = new Restaurant.Get(admin.Restaurant);
        }
        public class GetByRestaurant(IEnumerable<Get> Admins);
        
        public class Create(string Id);
        public class Update;
        public class Delete;
    }

    public static class SuperUser { }

    public static class Category
    {
        // TODO: PhotoLocation => Photo
        public class Get(string Name, string? Description, string? PhotoLocation,
            IEnumerable<string> MealIds) : Requests.Base.Get;
        // TODO: PhotoLocation => Photo
        public class GetByName(IEnumerable<Get> Categories);
        
        public class Create(string Id);
        public class Update;
        public class Delete;
        
        public class GetMeals(IEnumerable<Meal.Get> Meals);
        public class GetRestaurants(IEnumerable<Restaurant.Get> Restaurants);
    }
    
    public static class Restaurant
    {
        // TODO: PhotoLocation => Photo
        public class Get(string Name, string? Description, string? PhotoLocation,
            IEnumerable<string> AdminIds, IEnumerable<string> MealIds,
            IEnumerable<string> OrderIds) : Requests.Base.Get;
        // TODO: PhotoLocation => Photo
        public class GetByName(IEnumerable<Get> Restaurants);
        
        public class Create(string Id);
        public class Update;
        public class Delete;
        
        public class GetAdmins(IEnumerable<Admin.Get> Admins);
        public class GetMeals(IEnumerable<Meal.Get> Meals);
        public class GetOrders(IEnumerable<Order.Get> Orders);
    }

    public static class Meal
    {
        // TODO: PhotoLocation => Photo
        public class Get(string Name, string? Ingredients, string? PhotoLocation,
            string CategoryId, string RestaurantId) : Requests.Base.Get;
        // TODO: PhotoLocation => Photo
        public class GetByName(IEnumerable<Get> Meals);
        // TODO: PhotoLocation => Photo
        public class GetLikeName(IEnumerable<Get> Meals);
        
        public class Create(string Id);
        public class Update;
        public class Delete;
        
        public class GetCategory(Category.Get Category);
        public class GetRestaurant(Restaurant.Get Restaurants);
    }

    public static class Order
    {
        public class struct OrderItem(string MealId, ushort Count);
        
        public class Get(IEnumerable<OrderItem> OrderItems, string RestaurantId, DateTime? FulfillmentDate) : Requests.Base.Get;
        public class GetByDateTime(IEnumerable<Get> Orders);
        
        public class Create(string Id);
        public class Update;
        public class Delete;
        
        public class GetMeals(IEnumerable<Meal.Get> Meals);
        public class GetRestaurant(Restaurant.Get Restaurant);
    }
}