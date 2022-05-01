using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Users)]
public class User : BaseUser
{
    public override UserRole Role { init; get; } = UserRole.User;
    
    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();

    public Responses.User.Get Get() => new(this);
}