using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.Admins),
 Index(nameof(Restaurant))]
public record Admin(Restaurant Restaurant, BaseUser.UserRole Role = BaseUser.UserRole.Admin) : BaseUser
{
    public Responses.Admin.Get Get() => new(this);
}