using Microsoft.AspNetCore.Mvc;
using ServerSide.Data;

namespace ServerSide.Controllers;

public abstract class BaseController : Controller
{
    public IActionResult Exists(object? arg = null) => Conflict(arg);
    
    public IActionResult Error(object? arg = null) => NotFound(arg);
    
    public async Task Save(DataContext db) => await db.SaveChangesAsync();
}