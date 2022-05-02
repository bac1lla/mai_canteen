using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ServerSide.Data;

namespace ServerSide.Model.Archive;

[Table(DbRoutes.Archive.Logs),
 Index(nameof(CreationDate)),
 Index(nameof(DomainObject)),
 Index(nameof(UserId)),
 Index(nameof(Batch))]
public class Log : Model.Log
{
    /// TODO: move to db to save last value
    private static ulong _lastBatch = 0;
    
    public ulong Batch { set; get; }

    private Log(DomainObjectType domainObject, string userId, string userLogin, ActionType action) : 
        base(domainObject, userId, userLogin, action)
    {
        Batch = _lastBatch++;
    }

    public static Log FromNewLog(Model.Log log) => 
        new(log.DomainObject, log.UserId, log.UserLogin, log.Action);
}