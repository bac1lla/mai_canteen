namespace ServerSide.Contract.V1;

public static class ApiRoutes
{
    public const string Root = "";
    public const string Version = "V1";
    public const string Base = Root + "/" + Version;
    
    public static class Users
    {
        public const string SubRoute = "users";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
        public const string GetOrders = FullBase + "/orders/{Id}";
    }

    public static class Admins
    {
        public const string SubRoute = "admins";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
    }

    public static class SuperUsers
    {
        public const string SubRoute = "super";
        public const string FullBase = Base + "/" + SubRoute;
    }
    
    public static class Categories
    {
        public const string SubRoute = "categories";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string GetByName = FullBase + "/byName/{Name}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
        public const string GetMeals = FullBase + "/meals/{Id}";
        public const string GetRestaurants = FullBase + "/restaurants/{Id}";
    }
    
    public static class Restaurants
    {
        public const string SubRoute = "restaurants";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string GetByName = FullBase + "/byName/{Name}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
        public const string GetAdmins = FullBase + "/admins/{Id}";
        public const string GetMeals = FullBase + "/meals/{Id}";
        public const string GetOrders = FullBase + "/orders/{Id}";
    }
    
    public static class Meals
    {
        public const string SubRoute = "meals";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string GetByName = FullBase + "/byName/{Name}";
        public const string GetLikeName = FullBase + "/likeName/{Name}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
        public const string GetCategory = FullBase + "/category/{Id}";
        public const string GetRestaurant = FullBase + "/restaurant/{Id}";
    }
    
    public static class Orders
    {
        public const string SubRoute = "orders";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/{Id}";
        public const string GetByDateTime = FullBase + "/byDateTime/{Name}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
        public const string GetMeals = FullBase + "/meals/{Id}";
        public const string GetRestaurant = FullBase + "/restaurant/{Id}";
    }
}