using ServerSide.Models;

namespace ServerSide.Data;

public static class DbRoutes
{
    public const string Database = "mai_canteen";
    public const string Schema = "mai_canteen";

    public const string SuperUsers = Schema + ".superusers";
    public const string Admins = Schema + ".admins";
    public const string Users = Schema + ".users";

    public const string Categories = Schema + ".categories";
    public const string Restaurants = Schema + ".restaurants";
    public const string Meals = Schema + ".meals";

    public const string Orders = Schema + ".orders";
}