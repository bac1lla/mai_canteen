using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Logs, Schema = DbRoutes.Archive.Schema),
 Index(nameof(CreationDate), IsUnique = false),
 Index(nameof(DomainObject), IsUnique = false),
 Index(nameof(UserId), IsUnique = false),
 Index(nameof(Batch), IsUnique = false)]
public class Log : Model.Log
{
    /// TODO: move to db to save last value
    public static ulong LastBatch { private set; get; } = 0;
    
    public ulong Batch { set; get; }

    private Log(DomainObjectType domainObject, string userId, string userLogin, ActionType action) : 
        base(domainObject, userId, userLogin, action)
    {
        Batch = LastBatch++;
    }

    public static Log FromNewLog(Model.Log log) => 
        new(log.DomainObject, log.UserId, log.UserLogin, log.Action);
}