using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Logs, Schema = DbRoutes.Archive.Schema),
 Index(nameof(CreationDate), IsUnique = false),
 Index(nameof(UserId), IsUnique = false),
 Index(nameof(DomainObject), IsUnique = false),
 Index(nameof(Action), IsUnique = false)
 ]
public class Log : BaseEntity
{
    public string UserId { init; get; }
    public Model.Log.DomainObjectType DomainObject { init; get; }
    public Model.Log.ActionType Action { init; get; }
    
    public DateTime Batch { init; get; }
    
    private Log(string id, DateTime creationDate, bool isDeleted, 
        string userId, Model.Log.DomainObjectType domainObject, Model.Log.ActionType action,
        DateTime batch) 
        : base(id, creationDate, isDeleted)
    {
        UserId = userId;
        DomainObject = domainObject;
        Action = action;
        Batch = batch;
    }
    
    public Log(Model.Log log, DateTime batch) 
        : this(log.Id, log.CreationDate, log.IsDeleted, log.User.Id, log.DomainObject, log.Action, batch)
    { }
    
    protected Log() { }
}