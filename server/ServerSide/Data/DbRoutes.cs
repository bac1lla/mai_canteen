namespace ServerSide.Data;

public static class DbRoutes
{
    public const string Database = "MaiCanteen";
    public const string Schema = "MaiCanteen";

    public static class Local
    {
        public const string Host = "localhost:5432";
        public const string User = "MaiCanteen";
        public const string Password = "1234";
        
        public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
    }
    
    public static class Remote
    {
        public const string Host = "26.215.218.50:5432";
        public const string User = "postgres";
        public const string Password = "1790";
        
        public const string ConnectionString = $"Host={Host};User Id={User};Password={Password};Database={Database};";
    }
    
    public const string AllUsers = Schema + ".AllUsers";
    public const string Tokens = Schema + ".Tokens";
    
    public const string SuperUsers = Schema + ".SuperUsers";
    public const string Admins = Schema + ".Admins";
    public const string Users = Schema + ".Users";

    public const string Categories = Schema + ".Categories";
    public const string Restaurants = Schema + ".Restaurants";
    public const string Meals = Schema + ".Meals";
    
    public const string Orders = Schema + ".Orders";
    public const string OrderItems = Schema + ".OrderItems";

    public static class Archive
    {
        public const string Database = "MaiCanteenArchive";
        public const string Schema = "MaiCanteenArchive";
    
        public static class Local
        {
            public const string Host = "localhost:5432";
            public const string User = "MaiCanteenArchive";
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
    
        public const string Orders = Schema + ".Orders";
        public const string OrderItems = Schema + ".OrderItems";
    }
}