namespace ServerSide.Contract.V1;

public static class Responses
{
    public static class Users
    {
        public record Get();
        public record GetAll(List<Get> Users);
        public record Create(string Id);
    }
}