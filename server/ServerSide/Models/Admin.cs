using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Models;

[Table(DbRoutes.Admins)]
public class Admin : BaseUser
{
    public string Name { set; get; }
    
    public Restaurant Restaurant { set; get; }
    public string RestaurantId { get; set; }
}