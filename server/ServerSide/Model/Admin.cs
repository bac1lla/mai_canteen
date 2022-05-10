using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema),
 // Index(nameof(Restaurant), IsUnique = false)
]
public class Admin : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.Admin;

    public virtual Restaurant Restaurant { init; get; }
    // public string RestaurantId { init; get; }
    
    public Admin(string login, string name, string password, string salt, Restaurant restaurant)
        : base(login, name, password, salt)
    {
        Restaurant = restaurant;
    }
    
    protected Admin(string login, string name, string password, string salt) 
        : base(login, name, password, salt)
    { }
}