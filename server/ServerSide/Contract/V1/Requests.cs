namespace ServerSide.Contract.V1;

public static class Requests
{
    public static class Users
    {
        public record Get(ulong Id);
        public record GetAll();
        public record Create(string Name, string Login);
    }
}