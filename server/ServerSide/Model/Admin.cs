using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers, Schema = DbRoutes.Schema),
 // Index(nameof(Restaurant), IsUnique = false)
]
public class Admin : BaseUser, IEntity<Responses.Admin.Get, Responses.Admin.PartialGet>
{
    public override UserRole Role { get; init; } = UserRole.Admin;

    public Restaurant Restaurant { set; get; }

    // public Admin(string login, string password, string salt, string? name) : 
    //     base(login, password, salt, name)
    // {
    //     Restaurant = null;
    // }
    //
    // public Admin(string login, string password, string salt, string? name, Restaurant restaurant) : 
    //     base(login, password, salt, name)
    // {
    //     Restaurant = restaurant;
    // }
    //
    // public Admin SetRestaurant(Restaurant restaurant)
    // {
    //     Restaurant = restaurant;
    //     return this;
    // }
    
    public Responses.Admin.Get Get() => new(this);
    public Responses.Admin.PartialGet PartialGet() => new(this);
}