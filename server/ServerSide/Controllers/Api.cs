using Microsoft.AspNetCore.Mvc;
using ServerSide.Data;

namespace ServerSide.Controllers;

public class Api : Controller
{
    private DataContext Db { set; get; }

    public Api(DataContext db) => Db = db;

    [HttpGet("users/all")] 
    public IActionResult GetAllUsers() => Ok(Db.Users);
    
    [HttpGet("users/{id=}")] 
    public IActionResult GetAllUsers(string id, string name) => Ok(Db.Users.Find(id));
}