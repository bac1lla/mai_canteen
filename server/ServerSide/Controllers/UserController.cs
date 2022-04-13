using Microsoft.AspNetCore.Mvc;
using ServerSide.Contract.V1;
using ServerSide.Data;

namespace ServerSide.Controllers;

public class UserController : Controller
{
    private DataContext Db { set; get; }

    public UserController(DataContext dataContext) => Db = dataContext;

    [HttpGet(ApiRoutes.Users.Get)]
    public async Task<IActionResult> Get([FromRoute] string Id)
    {
        
    }
}