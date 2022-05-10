using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema)]
public class SuperUser : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.SuperUser;

    public SuperUser(string login, string? name, string password, string salt) 
        : base(login, name, password, salt)
    { }
}