namespace ServerSide.Models;

public class Admin
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string Name { set; get; }
    public string Login { set; get; }
    public string Password { set; get; }
    public string Salt { get; set; }
    
    public Restaurant Restaurant { set; get; }
    public ulong RestaurantId { get; set; }
}