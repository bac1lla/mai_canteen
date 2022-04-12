using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ServerSide.Models;

public abstract class BaseEntity
{
    [Key]
    public string Id { set; get; } = Guid.NewGuid().ToString();
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { get; set; } = DateTime.Now;
}

[Index(propertyNames: nameof(Login), Name = "Logins", IsUnique = true)]
public abstract class BaseUser : BaseEntity
{
    public string Login { set; get; }
    [DataType(DataType.Password)]
    public string Password { set; get; }
    public string Salt { set; get; }
}