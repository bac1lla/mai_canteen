using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.Users)]
public record User(BaseUser.UserRole Role = BaseUser.UserRole.User) : BaseUser
{
    public virtual IEnumerable<Order> Orders { set; get; } = new List<Order>();

    public Responses.User.Get Get() => new(this);
}