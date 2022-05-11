using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ServerSide.Data;
using ServerSide.Properties;
using ServerSide.Services;
using ServerSide.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllersWithViews();

// builder.Services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//     .AddRoles<IdentityRole>()
//     .AddUserStore<DataContext>();

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
    x =>
    {
        x.SwaggerDoc($"v1", new OpenApiInfo {Title = "MAICanteen API", Version = "1"});
        // x.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    });

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

// app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "MAICanteen API"));

// app.UseAuthorization();
// app.UseAuthorization();

// TODO
// app.MapControllerRoute("GeneralApi", "{controller=GeneralApi}/general");
// app.MapControllerRoute("AdminApi", "{controller=AdminApi}/admin");

// app.MapControllerRoute("Login", "{controller=AccountController}/login");

app.MapControllerRoute("Users", "{controller=UserController}/user");
// app.MapControllerRoute("Admins", "{controller=AdminController}/admin");
// app.MapControllerRoute("Categories", "{controller=CategoryController}/category");

app.MapRazorPages();

app.Run();