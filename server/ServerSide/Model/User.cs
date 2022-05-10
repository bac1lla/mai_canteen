using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema)]
public class User : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.User;

    public virtual IEnumerable<Order> Orders { init; get; } = new List<Order>();

    public User(string login, string? name, string password, string salt) :
        base(login, name, password, salt)
    { }
}