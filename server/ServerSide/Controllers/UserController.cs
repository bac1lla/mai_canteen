using Microsoft.AspNetCore.Mvc;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;
using ServerSide.Model.ModelExtensions;

namespace ServerSide.Controllers;

public class UserController : BaseController
{
    private DataContext Db { set; get; }
    
    public UserController(DataContext dataContext) => Db = dataContext;

    [HttpGet(ApiRoutes.User.Get)]
    public IActionResult GetUser([FromRoute] string UserId)
    {
        // Auth here
        
        var user = Db.Users.FirstOrDefault(u => u.Id == UserId);
        
        return user is null ? NotFound(UserId) : Ok(user.Get());
    }
    
    [HttpGet(ApiRoutes.User.PartialGet)]
    public IActionResult PartialGetUser([FromRoute] string UserId)
    {
        // Auth here
        
        var user = Db.Users.FirstOrDefault(u => u.Id == UserId);
        
        return user is null ? NotFound(UserId) : Ok(user.PartialGet());
    }
    
    [HttpPost(ApiRoutes.User.Create)]
    public async Task<IActionResult> CreateUser([FromBody] Requests.Base.User.Create body)
    {
        // Auth here
        
        var existingUser = Db.Users.FirstOrDefault(u => u.Login == body.Login);
        if (existingUser is not null) return Exists(body);
        
        var user = await Db.Users.AddAsync(body.Create());
        
        await Db.SaveChangesAsync();
        return Ok(user.Entity.Id);
    }
    
    [HttpPost(ApiRoutes.User.Update)]
    public async Task<IActionResult> UpdateUser([FromRoute] string UserId, [FromBody] Requests.Base.User.Update body)
    {
        // Auth here
        
        var user = Db.Users.FirstOrDefault(u => u.Login == body.Login);
        if (user is null) return NotFound(UserId);
        
        if (body.Name is not null) user.Name = body.Name;
        if (body.Password is not null) user.Password = body.Password;
        if (body.Salt is not null) user.Salt = body.Salt;
        
        await Db.SaveChangesAsync();
        return Ok(user.Id);
    }
    
    [HttpDelete(ApiRoutes.User.Delete)]
    public async Task<IActionResult> DeleteUser([FromRoute] string UserId)
    {
        // Auth here
        
        var user = Db.Users.FirstOrDefault(u => u.Id == UserId);
        if (user is null) return Error(UserId);
        
        Db.Users.Remove(user);
        
        await Save(Db);
        return Ok();
    }
    
    [HttpGet(ApiRoutes.User.GetOrders)]
    public IActionResult GetOrdersUser([FromRoute] string UserId)
    {
        // Auth here
        
        var user = Db.Users.FirstOrDefault(u => u.Id == UserId);
        if (user is null) return Error(UserId);
        
        return Ok(new Responses.User.GetOrders(user.Orders));
    }
}