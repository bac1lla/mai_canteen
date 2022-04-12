using Microsoft.EntityFrameworkCore;
using ServerSide.Models;

namespace ServerSide.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<User> Users { set; get; }
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Meal> Meals { get; set; }
    
    public DbSet<Order> Orders { get; set; }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
    //     optionsBuilder
    //         .UseNpgsql("Host=26.215.218.50:5432;Username=postgres;Password=1790;Database=postgres")
    //         .UseNpgsql("");
}