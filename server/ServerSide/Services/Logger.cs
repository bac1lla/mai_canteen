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


    private IEnumerable<Model.Log> GetAllNewLogs() => Db.Logs;

    private async Task InsertNewLogs(IEnumerable<Model.Log> logs) =>
        await Model.ModelExtensions.ArchiveModelExtensions.ArchiveLogs(logs, ArchiveDb);

    private async Task RemoveArchivedLogs() => 
        await Db.Database.ExecuteSqlInterpolatedAsync($"truncate table {DbRoutes.Schema}.{DbRoutes.Logs}");

    public async Task ArchiveLogs()
    {
        var newLogs = GetAllNewLogs();
        await InsertNewLogs(newLogs);
        await RemoveArchivedLogs();
    }
}