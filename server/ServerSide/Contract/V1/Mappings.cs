namespace ServerSide.Contract.V1;

public static class Mappings
{
    public static class SuperUsers
    {
        public static readonly Mapping Authorize = new(
            ApiRoutes.SuperUser.Authorize, 
            typeof(Requests.Base.User.Authorize),
            typeof(Responses.Base.User.Authorize),
            AuthorizationLevel.None
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[] {Authorize};
    }
    
    public static class Admin
    {
        public static readonly Mapping Get = new(
            ApiRoutes.Admin.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Admin.Get),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping GetByRestaurant = new(
            ApiRoutes.Admin.GetByRestaurant, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Admin.GetByRestaurant),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Authorize = new(
            ApiRoutes.Admin.Authorize, 
            typeof(Requests.Base.User.Authorize),
            typeof(Responses.Base.User.Authorize),
            AuthorizationLevel.None
        );
        
        public static readonly Mapping Create = new(
            ApiRoutes.Admin.Create, 
            typeof(Requests.Admin.Create),
            typeof(Responses.Base.Entity.Create),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.Admin.Update, 
            typeof(Requests.Admin.Update),
            typeof(Responses.Base.Entity.Update),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.Admin.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete),
            AuthorizationLevel.Admin
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, GetByRestaurant, Authorize, Create, Update, Delete
        };
    }
    
    public static class User
    {
        public static readonly Mapping Get = new(
            ApiRoutes.User.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.User.Get)
        );

        public static readonly Mapping Authorize = new(
            ApiRoutes.User.Authorize, 
            typeof(Requests.Base.User.Authorize),
            typeof(Responses.Base.User.Authorize),
            AuthorizationLevel.None
        );
        
        public static readonly Mapping Create = new(
            ApiRoutes.User.Create, 
            typeof(Requests.Admin.Create),
            typeof(Responses.Base.Entity.Create)
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.User.Update, 
            typeof(Requests.Base.User.Update),
            typeof(Responses.Base.Entity.Update)
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.User.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete)
        );

        public static readonly Mapping GetOrders = new(
            ApiRoutes.User.GetOrders,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.User.GetOrders)
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, Authorize, Create, Update, Delete, GetOrders
        };
    }
    
    public static class Category
    {
        public static readonly Mapping Get = new(
            ApiRoutes.Category.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Category.Get)
        );
        
        public static readonly Mapping GetAll = new(
            ApiRoutes.Category.GetAll, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Category.GetAll)
        );
        
        public static readonly Mapping GetByName = new(
            ApiRoutes.Category.GetByName, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Category.GetByName)
        );
        
        public static readonly Mapping Create = new(
            ApiRoutes.Category.Create, 
            typeof(Requests.Category.Create),
            typeof(Responses.Base.Entity.Create)
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.Category.Update, 
            typeof(Requests.Category.Update),
            typeof(Responses.Base.Entity.Update)
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.Category.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete)
        );

        public static readonly Mapping GetMeals = new(
            ApiRoutes.Category.GetMeals,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Category.GetMeals)
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, GetAll, GetByName, Create, Update, Delete, GetMeals
        };
    }
    
    public static class Meal
    {
        public static readonly Mapping Get = new(
            ApiRoutes.Meal.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.Get)
        );
        
        public static readonly Mapping GetAll = new(
            ApiRoutes.Meal.GetAll, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.GetAll)
        );
        
        public static readonly Mapping GetByName = new(
            ApiRoutes.Meal.GetByName, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.GetAll)
        );
        
        public static readonly Mapping GetLikeName = new(
            ApiRoutes.Meal.GetLikeName, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.GetAll)
        );
        
        public static readonly Mapping Create = new(
            ApiRoutes.Meal.Create, 
            typeof(Requests.Meal.Create),
            typeof(Responses.Base.Entity.Create),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.Meal.Update, 
            typeof(Requests.Meal.Update),
            typeof(Responses.Base.Entity.Update),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.Meal.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete),
            AuthorizationLevel.Admin
        );

        public static readonly Mapping GetCategory = new(
            ApiRoutes.Meal.GetCategory,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.GetCategory)
        );
        
        public static readonly Mapping GetRestaurant = new(
            ApiRoutes.Meal.GetRestaurant,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Meal.GetRestaurant)
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, GetAll, GetByName, GetLikeName, Create, Update, Delete, GetCategory, GetRestaurant
        };
    }
    
    public static class Restaurant
    {
        public static readonly Mapping Get = new(
            ApiRoutes.Restaurant.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.Get)
        );
        
        public static readonly Mapping GetAll = new(
            ApiRoutes.Restaurant.GetAll, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.GetAll)
        );
        
        public static readonly Mapping GetByName = new(
            ApiRoutes.Restaurant.GetByName, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.GetByName)
        );
        
        // public static readonly Mapping GetLikeName = new(
        //     ApiRoutes.Restaurant.GetLikeName, 
        //     typeof(Requests.Restaurant.GetByName),
        //     typeof(Responses.Restaurant.GetByName)
        // );
        
        public static readonly Mapping Create = new(
            ApiRoutes.Restaurant.Create, 
            typeof(Requests.Restaurant.Create),
            typeof(Responses.Base.Entity.Create),
            AuthorizationLevel.SuperUser
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.Restaurant.Update, 
            typeof(Requests.Restaurant.Update),
            typeof(Responses.Base.Entity.Update),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.Restaurant.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete),
            AuthorizationLevel.Admin
        );

        public static readonly Mapping GetMeals = new(
            ApiRoutes.Restaurant.GetMeals,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.GetMeals)
        );
        
        public static readonly Mapping GetOrders = new(
            ApiRoutes.Restaurant.GetOrders,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.GetOrders),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping GetAdmins = new(
            ApiRoutes.Restaurant.GetAdmins,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Restaurant.GetAdmins)
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, GetAll, GetByName, Create, Update, Delete, GetMeals, GetOrders, GetAdmins
        };
    }
    
    public static class Order
    {
        public static readonly Mapping Get = new(
            ApiRoutes.Order.Get, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.Get)
        );

        public static readonly Mapping GetByUser = new(
            ApiRoutes.Order.GetByUser, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.GetByUser),
            AuthorizationLevel.Admin
        );
        
        public static readonly Mapping GetByDateTime = new(
            ApiRoutes.Order.GetByDateTime, 
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.GetByUser),
            AuthorizationLevel.SuperUser
        );
        
        public static readonly Mapping Create = new(
            ApiRoutes.Order.Create, 
            typeof(Requests.Order.Create),
            typeof(Responses.Base.Entity.Create)
        );
        
        public static readonly Mapping Update = new(
            ApiRoutes.Order.Update, 
            typeof(Requests.Order.Update),
            typeof(Responses.Base.Entity.Update),
            AuthorizationLevel.SuperUser
        );
        
        public static readonly Mapping Delete = new(
            ApiRoutes.Order.Delete, 
            typeof(Requests.Base.Entity.Delete),
            typeof(Responses.Base.Entity.Delete),
            AuthorizationLevel.SuperUser
        );

        public static readonly Mapping GetMeals = new(
            ApiRoutes.Order.GetMeals,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.GetMeals)
        );
        
        public static readonly Mapping GetUser = new(
            ApiRoutes.Order.GetUser,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.GetUser)
        );
        
        public static readonly Mapping GetRestaurant = new(
            ApiRoutes.Order.GetRestaurant,
            typeof(Requests.Base.Entity.Get),
            typeof(Responses.Order.GetRestaurant)
        );

        public static IEnumerable<Mapping> Mappings { get; } = new[]
        {
            Get, GetByUser, GetByDateTime, Create, Update, Delete, GetMeals, GetUser, GetRestaurant
        };
    }
}