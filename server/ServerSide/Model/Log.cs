using System.ComponentModel.DataAnnotations.Schema;
using ServerSide.Data;

namespace ServerSide.Model;

[Table(DbRoutes.Logs)]
public class Log : BaseEntity
{
    public enum DomainObjectType
    {
        SuperUser,
        Admin,
        User,
        
        Category,
        Meal,
        Restaurant,
        
        Order
    }
    
    public enum ActionType
    {
        Create,
        Update,
        Delete
    }
    
    public BaseUser User { init; get; }
    // public string UserId { init; get; }\
    public DomainObjectType DomainObject { init; get; }
    public ActionType Action { init; get; }
    
    public Log(DomainObjectType domainObject, BaseUser user, ActionType action) 
        : base()
    {
        User = user;
        // UserId = user.Id;
        DomainObject = domainObject;
        Action = action;
    }
    
    protected Log() { }
}