using Microsoft.EntityFrameworkCore;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Services;

public interface ILogger
{ 
    void Log(Log.DomainObjectType domainObject, BaseUser user, Log.ActionType action);
    void Log(Log logMessage);
    void Log(IEnumerable<Log> logMessages);

    Task ArchiveLogs();
}

public class Logger : ILogger
{
    private DataContext Db { init; get; }
    
    private ArchiveDataContext ArchiveDb { init; get; }

    public Logger(DataContext db, ArchiveDataContext archiveDb)
    {
        Db = db;
        ArchiveDb = archiveDb;
    }

    
    public void Log(Model.Log.DomainObjectType domainObject, BaseUser user, Model.Log.ActionType action) =>
        Log(new Model.Log(domainObject, user, action));

    public void Log(Model.Log logMessage) => Db.Logs.Add(logMessage);

    public void Log(IEnumerable<Model.Log> logMessages) => Db.Logs.AddRange(logMessages);


    private ParallelQuery<Model.Log> GetAllNewLogs() => Db.Logs.AsParallel();

    public async Task ArchiveLogs() => 
        await ArchiveDb.Logs.AddRangeAsync(GetAllNewLogs().Select(Model.Archive.Log.FromNewLog));

    public async Task RemoveArchivedLogs() => 
        await new Task(
            _ => Db.Logs.RemoveRange(
                ArchiveDb.Logs
                    .Where(l => l.Batch == Model.Archive.Log.LastBatch - 1)
                    // .Select(l => new Model.Log(l.DomainObject, l.UserId, l.UserLogin, l.Action))
                    // .ToArray()
            ),
            null
        );
}