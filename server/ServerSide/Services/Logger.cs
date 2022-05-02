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

    
    public void Log(Log.DomainObjectType domainObject, BaseUser user, Log.ActionType action) =>
        Log(new Log(domainObject, user, action));

    public void Log(Log logMessage) => Db.Logs.Add(logMessage);

    public void Log(IEnumerable<Log> logMessages) => Db.Logs.AddRange(logMessages);


    private ParallelQuery<Model.Log> GetAllNewLogs() => Db.Logs.AsParallel();

    public async Task ArchiveLogs()
    {
        await ArchiveDb
            .Logs
            .AddRangeAsync(
                GetAllNewLogs()
                    .Select(Model.Archive.Log.FromNewLog)
            );
    }
}