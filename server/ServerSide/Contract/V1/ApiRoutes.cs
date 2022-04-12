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

        public const string GetAll = FullBase + "/all";
        public const string Get = FullBase + "/{user}";
        public const string Create = FullBase + "/create";
        public const string Update = FullBase + "/update";
    }
}