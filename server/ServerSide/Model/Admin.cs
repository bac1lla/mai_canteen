using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.AllUsers),
 Index(nameof(Restaurant))]
public class Admin : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.Admin;

    public Restaurant Restaurant { set; get; }

    public Admin(string login, string password, string salt, string? name) : 
        base(login, password, salt, name)
    {
        Restaurant = null;
    }
    
    public Admin(string login, string password, string salt, string? name, Restaurant restaurant) : 
        base(login, password, salt, name)
    {
        Restaurant = restaurant;
    }

    public Admin SetRestaurant(Restaurant restaurant)
    {
        Restaurant = restaurant;
        return this;
    }
    
    public Responses.Admin.Get Get() => new(this);
}