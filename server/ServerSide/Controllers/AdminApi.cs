using Microsoft.AspNetCore.Mvc;
using ServerSide.Data;

namespace ServerSide.Controllers;

[Route("admin_api")]
public class AdminApi : Controller
{
    private DataContext Db { set; get; }

    public AdminApi(DataContext db) => Db = db;

    [HttpGet("admin/{id}")]
    public IActionResult GetAdminByName([FromRoute] string id) => Ok(Db.Admins.Find(id));

    [HttpGet("orders/{restaurantId}")]
    public IActionResult GetOrders(string restaurantId) => 
        Ok(Db.Orders.Where(order => order.RestaurantId == restaurantId));
    
    // [HttpGet()]
}