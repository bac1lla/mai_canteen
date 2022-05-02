namespace ServerSide.Data;

public static class DbRoutes
{
    public const string Database = "mai_canteen";
    public const string Schema = "mai_canteen";

    public static class Local
    {
        public const string Host = "localhost";
        public const string User = "mai_canteen";
        public const string Password = "12345";
        
        public const string ConnectionString = 
            $"Host={Host};Port=5432;User Id={User};Password={Password};Database={Database};";
    }
    
    public static class Remote
    {
        public const string Host = "26.215.218.50";
        public const string User = "mai_canteen";
        public const string Password = "12345";
        
        public const string ConnectionString = 
            $"Host={Host};Port=5432;User Id={User};Password={Password};Database={Database};";
    }
    
    public const string Logs = Schema + ".t_logs";

    public const string Tokens = Schema + ".t_user_tokens";
    
    public const string AllUsers = Schema + ".t_all_users";
    public const string SuperUsers = Schema + ".v_super_users";
    public const string Admins = Schema + ".v_admins";
    public const string Users = Schema + ".v_users";

    public const string Categories = Schema + ".t_categories";
    public const string Restaurants = Schema + ".t_restaurants";
    public const string Meals = Schema + ".t_meals";
    
    public const string Orders = Schema + ".t_oders";
    public const string OrderItems = Schema + ".t_order_items";

    public static class Archive
    {
        public const string Database = "mai_canteen_archive";
        public const string Schema = "mai_canteen_archive";
    
        public static class Local
        {
            public const string Host = "localhost";
            public const string User = "mai_canteen_archive";
            public const string Password = "12345";
        
            public const string ConnectionString = 
                $"Host={Host};Port=5432;User Id={User};Password={Password};Database={Database};";
        }
    
        public static class Remote
        {
            public const string Host = "26.215.218.50";
            public const string User = "mai_canteen_archive";
            public const string Password = "12345";
        
            public const string ConnectionString = 
                $"Host={Host};Port=5432;User Id={User};Password={Password};Database={Database};";
        }
    
        public const string Orders = Schema + ".t_orders";
        
        public const string Logs = Schema + ".t_logs";
    }
}