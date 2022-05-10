namespace ServerSide.Contract.V1;

public static class ApiRoutes
{
    public const string Root = "Api";
    public const string Version = "V1";
    public const string Base = Root + "/" + Version;
    
    public static class User
    {
        public const string SubRoute = "User";
        public const string FullBase = Base + "/" + SubRoute;

        public const string Authorize = FullBase + "Authorize/{UserId?}";
        
        public const string Get = FullBase + "/Get/{UserId}";
        public const string PartialGet = FullBase + "/PartialGet/{UserId}";
        // public const string GetAll = FullBase + "/All";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{UserId}";
        public const string Delete = FullBase + "/Delete/{UserId}";
        
        public const string GetOrders = FullBase + "/GetOrders/{UserId}";
    }

    public static class Admin
    {
        public const string SubRoute = "Admin";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Authorize = FullBase + "Authorize/{UserId?}";
        
        public const string Get = FullBase + "/Get/{AdminId}";
        public const string PartialGet = FullBase + "/PartialGet/{AdminId}";
        public const string GetByRestaurant = FullBase + "/GetByRestaurant/{RestaurantId}";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{AdminId}";
        public const string Delete = FullBase + "/Delete/{AdminId}";
    }

    public static class SuperUser
    {
        public const string SubRoute = "Super";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Authorize = FullBase + "Authorize/{UserId?}";
    }
    
    public static class Category
    {
        public const string SubRoute = "Category";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/Get/{CategoryId}";
        public const string PartialGet = FullBase + "/PartialGet/{CategoryId}";
        public const string GetAll = FullBase + "/All";
        public const string GetByName = FullBase + "/GetByName/{Name}";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{CategoryId}";
        public const string Delete = FullBase + "/Delete/{CategoryId}";
        
        public const string GetMeals = FullBase + "/GetMeals/{CategoryId}";
        // public const string GetRestaurants = FullBase + "/Restaurants/{CategoryId}";
    }
    
    public static class Restaurant
    {
        public const string SubRoute = "Restaurant";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/Get/{RestaurantId}";
        public const string PartialGet = FullBase + "/PartialGet/{RestaurantId}";
        public const string GetAll = FullBase + "/All";
        public const string GetByName = FullBase + "/GetByName/{Name}";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{RestaurantId}";
        public const string Delete = FullBase + "/Delete/{RestaurantId}";
        
        public const string GetAdmins = FullBase + "/GetAdmins/{RestaurantId}";
        public const string GetMeals = FullBase + "/GetMeals/{RestaurantId}";
        public const string GetOrders = FullBase + "/GetOrders/{RestaurantId}";
    }
    
    public static class Meal
    {
        public const string SubRoute = "Meal";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/Get/{MealId}";
        public const string PartialGet = FullBase + "/PartialGet/{MealId}";
        public const string GetAll = FullBase + "/All";
        public const string GetByName = FullBase + "/GetByName/{Name}";
        public const string GetLikeName = FullBase + "/SearchByName/{Name}";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{MealId}";
        public const string Delete = FullBase + "/Delete/{MealId}";
        
        public const string GetCategory = FullBase + "/GetCategories/{MealId}";
        public const string GetRestaurant = FullBase + "/GetRestaurant/{MealId}";
    }
    
    public static class Order
    {
        public const string SubRoute = "Order";
        public const string FullBase = Base + "/" + SubRoute;
        
        public const string Get = FullBase + "/Get/{OrderId}";
        public const string PartialGet = FullBase + "/PartialGet/{OrderId}";
        public const string GetByDateTime = FullBase + "/GetByDateTime/{DateTime}";
        public const string GetByUser = FullBase + "/GetByUser/{UserId}";
        
        public const string Create = FullBase + "/Create";
        public const string Update = FullBase + "/Update/{OrderId}";
        public const string Delete = FullBase + "/Delete/{OrderId}";
        
        public const string GetMeals = FullBase + "/GetMeals/{OrderId}";
        public const string GetRestaurant = FullBase + "/GetRestaurant/{OrderId}";
        public const string GetUser = FullBase + "/GetUser/{OrderId}";
    }
}