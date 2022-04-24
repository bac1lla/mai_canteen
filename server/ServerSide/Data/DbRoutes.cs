namespace ServerSide.Data;

public static class DbRoutes
{
    public const string Database = "mai_canteen";
    public const string Schema = "mai_canteen";

    public static class Local
    {
        public const string Host = "localhost:5432";
        public const string User = "mai_canteen";
        public const string Password = "12345";
        
        public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
    }
    
    public static class Remote
    {
        public const string Host = "26.215.218.50:5432";
        public const string User = "postgres";
        public const string Password = "1790";
        
        public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
    }
    
    public const string BaseUsers = Schema + ".base_users";
    public const string SuperUsers = Schema + ".superusers";
    public const string Admins = Schema + ".admins";
    public const string Users = Schema + ".users";

    public const string Categories = Schema + ".categories";
    public const string Restaurants = Schema + ".restaurants";
    public const string Meals = Schema + ".meals";
    public const string Orders = Schema + ".orders";

    public static class Archive
    {
        public const string Database = "mai_canteen_archive";
        public const string Schema = "mai_canteen_archive";

        public static class Local
        {
            public const string Host = "localhost:5432";
            public const string User = "mai_canteen_archive";
            public const string Password = "12345";
        
            public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
        }
    
        public static class Remote
        {
            public const string Host = "26.215.218.50:5432";
            public const string User = "postgres";
            public const string Password = "1790";
        
            public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
        }
        
        public const string BaseUsers = Schema + ".base_users";
        public const string SuperUsers = Schema + ".superusers";
        public const string Admins = Schema + ".admins";
        public const string Users = Schema + ".users";

        public const string Categories = Schema + ".categories";
        public const string Restaurants = Schema + ".restaurants";
        public const string Meals = Schema + ".meals";
        public const string Orders = Schema + ".orders";
    }
}