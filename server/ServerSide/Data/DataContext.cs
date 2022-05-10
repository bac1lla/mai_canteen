using Microsoft.EntityFrameworkCore;
using ServerSide.Model;

namespace ServerSide.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Price> Prices { get; set; }
    
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Meal> Meals { get; set; }
    
    public DbSet<BaseUser> AllUsers { get; set; }
    public DbSet<SuperUser> SuperUsers { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<User> Users { set; get; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Order.Item> OrderItems { get; set; }

    public DbSet<Log> Logs { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseUser>()
            .HasDiscriminator(u => u.Role)
            .HasValue<SuperUser>(BaseUser.UserRole.SuperUser)
            .HasValue<Admin>(BaseUser.UserRole.Admin)
            .HasValue<User>(BaseUser.UserRole.User)
            .IsComplete();

        modelBuilder.Entity<Order.Item>()
            .HasKey(i => new { i.MealId, i.OrderId });

        modelBuilder.Entity<Meal>()
            .HasOne<Category>(m => m.Category)
            .WithMany(c => c.Meals);

        modelBuilder.Entity<Meal>()
            .HasOne<Restaurant>(m => m.Restaurant)
            .WithMany(r => r.Meals);

        modelBuilder.Entity<Price>()
            .HasOne<Meal>(p => p.Meal)
            .WithOne(m => m.CurrentPrice)
            .HasForeignKey<Price>(p => p.MealId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder
            .UseNpgsql(DbRoutes.Local.ConnectionString);
            // .UseNpgsql(DbRoutes.Remote.ConnectionString);
}