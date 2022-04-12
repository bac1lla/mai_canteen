using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Models;

[Table(DbRoutes.SuperUsers)]
public class SuperUsers : BaseUser
{
    
}