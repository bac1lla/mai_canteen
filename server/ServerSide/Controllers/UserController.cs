using Microsoft.AspNetCore.Mvc;
using Route = ServerSide.Contract.V1.ApiRoutes.User;
using Request = ServerSide.Contract.V1.Requests.User;
using Response = ServerSide.Contract.V1.Responses.User;
using ServerSide.Data;

namespace ServerSide.Controllers;

public class UserController : Controller
{
    private DataContext Db { set; get; }
    
    public UserController(DataContext dataContext) => Db = dataContext;

    // [HttpGet(Routes.Get)]
    // public async Task<IActionResult> Get([FromBody] Requests.Get getUser)
    // {
    //     var user = await Db.Users.FindAsync(getUser.Id);
    //     return user is null ? NotFound(null) : Ok(new Responses.Get(user));
    // }
}