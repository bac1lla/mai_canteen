using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;
using Helpers = ServerSide.Model.ModelExtensions.ModelHelpersAndBasicExtensions;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema),
 Index(nameof(Login), IsUnique = true), 
 Index(nameof(Name), IsUnique = false),
 Index(nameof(Role), IsUnique = false)]
public abstract class BaseUser : BaseEntity
{
    public enum UserRole
    {
        User,
        Admin,
        SuperUser
    }
    
    public string Login { init; get; }
    public string? Name { set; get; }
    
    public string Password { set; get; }
    public string Salt { set; get; }
    
    public abstract UserRole Role { init; get; }

    public string TokenValue { set; get; }
    public DateTime TokenExpirationDate { set; get; }

    public bool IsBanned { set; get; } = false;
    
    protected BaseUser(string login, string? name, string password, string salt)
    {
        Login = login;
        Name = name;

        Password = password;
        Salt = salt;

        Helpers.NewToken(this);
    }
}