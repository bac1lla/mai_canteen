using Microsoft.EntityFrameworkCore;
using ServerSide.Model;
using Log = ServerSide.Model.Archive.Log;

namespace ServerSide.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<BaseUser> AllUsers { get; set; }
    // public DbSet<Token> Tokens { get; set; }

    public DbSet<SuperUser> SuperUsers { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<User> Users { set; get; }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Meal> Meals { get; set; }
    
    public DbSet<Model.Order> Orders { get; set; }
    // public DbSet<Model.Order.Item> OrderItems { get; set; }

    public DbSet<Model.Log> Logs { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseUser>()
            .HasDiscriminator(u => u.Role)
            .HasValue<SuperUser>(BaseUser.UserRole.Super)
            .HasValue<Admin>(BaseUser.UserRole.Admin)
            .HasValue<User>(BaseUser.UserRole.User)
            .IsComplete();

        modelBuilder.Entity<Admin>()
            .HasOne<Restaurant>(a => a.Restaurant)
            .WithMany(r => r.Admins);

        modelBuilder.Entity<Order.Item>().HasKey(i => new {i.Meal, i.Order});

        // modelBuilder.Entity<BaseUser>()
        //     .HasMany<Token>(u => u.Tokens)
        //     .WithOne(t => t.User);

        // modelBuilder.Entity<BaseUser>()
        //     .HasOne<Token>(u => u.LastToken)
        //     .WithOne(t => t.User);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder
            .UseNpgsql(DbRoutes.Local.ConnectionString);
            // .UseNpgsql(DbRoutes.Remote.ConnectionString);
}