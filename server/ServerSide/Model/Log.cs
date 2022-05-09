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
    
    public Log(DomainObjectType domainObject, BaseUser user, ActionType action) :
        this(domainObject, user.Id, user.Login, action)
    { }
    
    public Log(DomainObjectType domainObject, string userId, string userLogin, ActionType action) 
    {
        DomainObject = domainObject;
        UserId = userId;
        UserLogin = userLogin;
        Action = action;
    }
    
    public DomainObjectType DomainObject { init; get; }
    public string UserId { init; get; }
    public string UserLogin { init; get; }
    public ActionType Action { init; get; }
}