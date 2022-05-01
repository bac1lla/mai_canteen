using Microsoft.EntityFrameworkCore;
using ServerSide.Model;

namespace ServerSide.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<BaseUser> AllUsers { set; get; }
    public DbSet<Token> Tokens { set; get; }

    public DbSet<SuperUser> SuperUsers { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<User> Users { set; get; }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Meal> Meals { get; set; }
    
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder
            .UseNpgsql("Server=localhost;Port=5432;User Id=mai_canteen;Password=1234;Database=mai_canteen;");
            // .UseNpgsql("Server=26.215.218.50;Port=5432;User Id=postgres;Password=1790;Database=postgres;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasBaseType<BaseUser>().ToTable(DbRoutes.AllUsers);
        modelBuilder.Entity<Admin>().HasBaseType<BaseUser>().ToTable(DbRoutes.AllUsers);
        modelBuilder.Entity<SuperUser>().HasBaseType<BaseUser>().ToTable(DbRoutes.AllUsers);

        modelBuilder.Entity<Admin>()
            .HasOne<Restaurant>(a => a.Restaurant)
            .WithMany(r => r.Admins);

        modelBuilder.Entity<BaseUser>()
            .HasMany<Token>(u => u.Tokens)
            .WithOne(t => t.User);

        modelBuilder.Entity<BaseUser>()
            .HasOne<Token>(u => u.LastToken)
            .WithOne(t => t.User);
    }
}