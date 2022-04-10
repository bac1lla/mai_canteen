namespace ServerSide.Models;

public class User
{
    public string Id { set; get; }
    public string Name { set; get; }
    public string Password { get; set; }
    public string Salt { get; set; }
}