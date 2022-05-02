using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model;

namespace ServerSide.Controllers;

public class GeneralController : Controller
{
    private readonly DataContext _db;

    public GeneralController(DataContext db) => _db = db;

    // [HttpGet(ApiRoutes.User.GetOrders)]
    // public async Task<IActionResult> UserGetOrders([FromRoute] string UserId)
    // {
    //     var user =  await _db.Users.FindAsync(UserId);
    //     if (user is null) return Error();
    //     return Ok(
    //         new Responses.User.GetOrders(
    //             user.Orders.Select(o => new Responses.Order.Get(
    //                     o.Items.Select(i => new Responses.Order.OrderItem(i.MealId, i.Count)),
    //                     o.RestaurantId,
    //                     o.CreationDate))));
    // }
    
    public IActionResult Error() => new NotFoundResult();
}