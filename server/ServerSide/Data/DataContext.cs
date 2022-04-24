using Microsoft.EntityFrameworkCore;
using ServerSide.Domain;

namespace ServerSide.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<SuperUser> SuperUsers { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<User> Users { set; get; }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Meal> Meals { get; set; }
    
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
        optionsBuilder
            // .UseNpgsql(DbRoutes.Remote.ConnectionString);
            .UseNpgsql(DbRoutes.Local.ConnectionString);
}