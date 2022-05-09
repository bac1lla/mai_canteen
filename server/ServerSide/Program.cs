using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ServerSide.Data;
using ServerSide.Properties;
using ServerSide.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(DbRoutes.Local.ConnectionString);
    options.UseNpgsql(DbRoutes.Remote.ConnectionString);
});

builder.Services.AddDbContext<ArchiveDataContext>(options =>
{
    options.UseNpgsql(DbRoutes.Archive.Local.ConnectionString);
    options.UseNpgsql(DbRoutes.Archive.Remote.ConnectionString);
});

builder.Services.Add(new ServiceDescriptor(
    typeof(ServerSide.Services.ILogger), 
    typeof(Logger), 
    ServiceLifetime.Scoped)
);

builder.Services.Add(new ServiceDescriptor(
    typeof(ServerSide.Services.IAuthorizer), 
    typeof(Authorizer), 
    ServiceLifetime.Scoped)
);

builder.Services.AddMvc();
// builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddSwaggerGen(
    x => x.SwaggerDoc($"V1", new OpenApiInfo{ Title = "MAICanteenAPI", Version = "1"}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

var swaggerOptions = new SwaggerOptions();
app.Configuration.GetSection(nameof(swaggerOptions)).Bind(swaggerOptions);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// app.UseAuthorization();
// app.UseAuthorization();

// TODO
// app.MapControllerRoute("GeneralApi", "{controller=GeneralApi}/general");
// app.MapControllerRoute("AdminApi", "{controller=AdminApi}/admin");
// app.MapControllerRoute("UserApi", "{controller=UserApi}/user");

app.MapRazorPages();
    
app.Run();