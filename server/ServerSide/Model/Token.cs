using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Tokens),
 Index(nameof(Value), IsUnique = true)]
public class Token : BaseEntity
{
    private static readonly TimeSpan ExpirationInterval = TimeSpan.FromMinutes(30);
    
    // TODO: remove placeholder
    private static string NewValue(BaseUser user) => new StringBuilder()
        .Append(user.Role)
        .Append(user.Id)
        .Append(DateTime.Now)
        .ToString();

    public string Value { init; get; }
    
    public BaseUser User { init; get; }
    public string UserId { init; get; }
    
    public DateTime ExpirationDate { init; get; }

    public bool IsValid => DateTime.Now <= ExpirationDate;

    protected Token(string value) : base()
    {
        Value = value;
        ExpirationDate = CreationDate + ExpirationInterval;
    }

    public static Token NewToken(BaseUser user) => new(NewValue(user));
}