using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Models;

[Table(DbRoutes.Users)]
public class User : BaseUser
{
    public string? Name { set; get; } = null;
    
    public List<Order> Orders { set; get; } = new();
}