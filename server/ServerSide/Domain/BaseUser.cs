using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Domain;

[Table(DbRoutes.BaseUsers),
 Index(propertyNames: nameof(Login), IsUnique = true), 
 Index(propertyNames: nameof(Name), IsUnique = false)]
public abstract record BaseUser : BaseEntity
{
    public enum UserRole
    {
        User,
        Admin,
        Super
    }
    
    public string Login { set; get; }
    public string? Name { set; get; } = null;
    
    public string NameToShow  => Name ?? Login;
    
    [DataType(DataType.Password)]
    public string Password { set; get; }
    [DataType(DataType.Password)]
    public string Salt { set; get; }
    
    public abstract UserRole Role { init; get; }
}