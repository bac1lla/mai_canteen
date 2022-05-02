using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers)]
public class User : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.User;

    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();

    public User(string login, string password, string salt, string? name) : 
        base(login, password, salt, name)
    {
        Orders = null;
    }
    
    public User(string login, string password, string salt, string? name, IEnumerable<Order> orders) : 
        base(login, password, salt, name)
    {
        Orders = orders;
    }

    public User SetOrders(IEnumerable<Order> orders)
    {
        Orders = orders;
        return this;
    }

    public Responses.User.Get Get() => new(this);
}