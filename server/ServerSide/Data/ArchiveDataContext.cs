using Microsoft.EntityFrameworkCore;

namespace ServerSide.Data;

public class ArchiveDataContext : DbContext
{
    public DbSet<Model.Archive.Order> Orders { set; get; }
    
    public DbSet<Model.Archive.Log> Logs { set; get; }
    
    public ArchiveDataContext(DbContextOptions<ArchiveDataContext> options) 
        : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder
            // .UseNpgsql(DbRoutes.Archive.Local.ConnectionString);
            .UseNpgsql(DbRoutes.Archive.Remote.ConnectionString);
}