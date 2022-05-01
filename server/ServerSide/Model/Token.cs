using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Tokens),
 Index(nameof(User)),
 Index(nameof(Value))]
public class Token : BaseEntity
{
    public static readonly TimeSpan ExpirationInterval = TimeSpan.FromHours(2);
    
    public string Value { init; get; }
    
    public DateTime ExpirationDate => CreationDate + ExpirationInterval;
    public bool IsExpired => ExpirationDate >= DateTime.Now;
    
    public BaseUser User { init; get; }
}