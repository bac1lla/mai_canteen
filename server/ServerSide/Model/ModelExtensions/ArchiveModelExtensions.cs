using ServerSide.Data;

namespace ServerSide.Model.ModelExtensions;

public static class ArchiveModelExtensions
{
    private static DateTime? _lastBatch = null;
    public static DateTime? LastBatch => _lastBatch;
    
    private static bool _batchInProgress = false;
    
    public static Model.Archive.Log ToArchiveLog(this Model.Log log, DateTime batch) => new(log, batch);

    private static IEnumerable<Model.Archive.Log> ToArchiveLogs(IEnumerable<Model.Log> logs, DateTime batch) => 
        logs.Select(log => ToArchiveLog(log, batch));

    public static async Task ArchiveLogs(IEnumerable<Model.Log> logs, ArchiveDataContext db)
    {
        _batchInProgress = true;
        _lastBatch = DateTime.Now;
        await db.Logs.AddRangeAsync(ToArchiveLogs(logs, _lastBatch.Value));
        _batchInProgress = false;
    }
}