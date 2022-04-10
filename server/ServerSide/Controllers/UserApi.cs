using Microsoft.AspNetCore.Mvc;
using ServerSide.Data;

namespace ServerSide.Controllers;

[Route("user_api")]
public class Api : Controller
{
    private DataContext Db { set; get; }

    public Api(DataContext db) => Db = db;

    [HttpGet("users/all")] 
    public IActionResult GetAllUsers() => Ok(Db.Users);
    
    [HttpGet("users/{id}")] 
    public IActionResult GetUserById([FromRoute] string id) => Ok(Db.Users.Find(id));

    [HttpGet("users/{name}")]
    public IActionResult GetUsersByName([FromRoute] string name) => 
        Ok(Db.Users.Where(user => user.Name == name));

    public IActionResult Error(object? arg = null) => NotFound(arg);
}