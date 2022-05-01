using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Admins), 
 Index(nameof(Restaurant))]
public class Admin : BaseUser
{
    public override UserRole Role { get; init; } = UserRole.Admin;
    
    public Restaurant Restaurant { set; get; }

    public Responses.Admin.Get Get() => new(this);
}