using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.SuperUsers)]
public class SuperUser : BaseUser
{
    public override UserRole Role { init; get; } = UserRole.Super;
}