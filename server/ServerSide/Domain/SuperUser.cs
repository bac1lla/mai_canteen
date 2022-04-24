using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.SuperUsers)]
public record SuperUser(BaseUser.UserRole Role = BaseUser.UserRole.Super) : BaseUser;