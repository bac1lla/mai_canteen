using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers),
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

    public string Login { init; get; }
    // public string Email { set; get; }
    public string? Name { set; get; } = null;
    
    public string NameToShow  => Name ?? Login;
    
    [DataType(DataType.Password)]
    public string Password { set; get; }
    [DataType(DataType.Password)]
    public string Salt { set; get; }
    
    public abstract UserRole Role { init; get; }

    public virtual IEnumerable<Token> Tokens { set; get; } = new List<Token>();
    public Token? LastToken => Tokens.FirstOrDefault(t => !t.IsExpired);
    
    public bool IsAuthorized
    {
        get
        {
            if (LastToken is null || LastToken.IsDeleted) return false;
            if (LastToken.IsExpired)
            {
                LastToken.IsDeleted = true;
                return false;
            }
            return true;
        }
    }

    // TODO: remove dummy
    private string NewTokenValue => Login + Id + Role;

    public void NewToken() => LastToken = new Token { User = this, Value = NewTokenValue };

}