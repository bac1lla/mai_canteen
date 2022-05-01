using Microsoft.AspNetCore.Mvc;

namespace ServerSide.Controllers;

public class StaticController : Controller
{
    
    
    public IActionResult Index() => NotFound();
}