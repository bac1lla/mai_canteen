using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema)]
public class SuperUser : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.Super;

    public SuperUser(string login, string password, string salt, string? name) : 
        base(login, password, salt, name)
    { }
}