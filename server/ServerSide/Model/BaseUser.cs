using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

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
        Super
    }

    // private static string UserRoleString(UserRole role) => role.ToString();

    public string Login { init; get; }
    // public string Email { set; get; }
    public string? Name { set; get; } = null;
    
    public string NameToShow => Name ?? Login;
    
    // [DataType(DataType.Password)]
    public string Password { set; get; }
    // [DataType(DataType.Password)]
    public string Salt { set; get; }
    
    public abstract UserRole Role { init; get; }

    public Token Token { set; get; }

    public bool IsAuthorized => Token.IsValid;

    protected BaseUser() :
        this(string.Empty, string.Empty, string.Empty, null)
    { }
    
    protected BaseUser(string login, string password, string salt, string? name)
    {
        Login = login;
        Name = name;

        Password = password;
        Salt = salt;
        
        Token = Token.NewToken(this);
    }

    public Responses.Base.User.Get Get() => new(this);
    public Responses.Base.User.PartialGet PartialGet() => new(this);
}