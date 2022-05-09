using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Tokens, Schema = DbRoutes.Schema),
 Index(nameof(Value), IsUnique = true)]
public class Token : BaseEntity, IEntity<Responses.Token.Get, Responses.Token.PartialGet>
{
    private static readonly TimeSpan ExpirationInterval = TimeSpan.FromMinutes(30);
    
    // TODO: remove placeholder
    private static string NewValue(BaseUser user) => new StringBuilder()
        .Append(user.Role).Append(';')
        .Append(user.Id).Append(';')
        .Append(DateTime.Now)
        .ToString();

    public static Token NewToken(BaseUser user) => new(NewValue(user), user);

    public string Value => Id;
    
    public BaseUser User { init; get; }
    public string UserId { init; get; }
    
    public BaseUser.UserRole UserRole { init; get; }
    
    public DateTime ExpirationDate { set; get; }

    public bool IsValid => DateTime.Now <= ExpirationDate;

    private Token(string value, BaseUser user) : base(value)
    {
        User = user;
        UserId = user.Id;
        UserRole = user.Role;
        ExpirationDate = CreationDate + ExpirationInterval;
    }

    public void Refresh() => ExpirationDate = DateTime.Now + ExpirationInterval;

    public Responses.Token.Get Get() => new(this);
    public Responses.Token.PartialGet PartialGet() => new(this);
}