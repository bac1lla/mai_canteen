namespace ServerSide.Models;

public class User
{
    private static ulong _lastId = 0;
    public ulong Id { set; get; } = ++_lastId;
    
    public string Name { set; get; }
    public string Password { get; set; }
    public string Salt { get; set; }
    
    public List<Order> Orders { set; get; } = new();
}