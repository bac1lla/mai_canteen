using Microsoft.AspNetCore.Mvc;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model.ModelExtensions;

namespace ServerSide.Controllers;

// public class AdminController : BaseController
// {
//     private DataContext Db { set; get; }
//     
//     public AdminController(DataContext dataContext) => Db = dataContext;
//
//     [HttpGet(ApiRoutes.Admin.Get)]
//     public IActionResult GetAdmin([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var admin = Db.Admins.FirstOrDefault(a => a.Id == AdminId);
//         
//         return admin is null ? NotFound(AdminId) : Ok(admin.Get());
//     }
//     
//     [HttpGet(ApiRoutes.Admin.PartialGet)]
//     public IActionResult PartialGetAdmin([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var admin = Db.Admins.FirstOrDefault(a => a.Id == AdminId);
//         
//         return admin is null ? NotFound(AdminId) : Ok(admin.PartialGet());
//     }
//     
//     // [HttpGet(ApiRoutes.Admin.PartialGet)]
//     // public IActionResult GetByRestaurant([FromRoute] string RestaurantId)
//     // {
//     //     // Auth here
//     //     
//     //     var admin = Db.Admins.FirstOrDefault(a => a.Restaurant.Id == RestaurantId);
//     //     
//     //     return admin is null ? NotFound(RestaurantId) : Ok(admin.Get());
//     // }
//     
//     [HttpPost(ApiRoutes.Admin.Create)]
//     public async Task<IActionResult> CreateAdmin([FromBody] Requests.Admin.Create body)
//     {
//         // Auth here
//         
//         var existingAdmin = Db.Admins.FirstOrDefault(a => a.Login == body.Login);
//         if (existingAdmin is null) return Exists(body);
//         
//         var admin = await Db.Admins.AddAsync(body.Create());
//         
//         await Db.SaveChangesAsync();
//         return Ok(admin.Entity.Id);
//     }
//     
//     [HttpPost(ApiRoutes.Admin.Update)]
//     public async Task<IActionResult> UpdateAdmin([FromRoute] string AdminId, [FromBody] Requests.Base.User.Update body)
//     {
//         // Auth here
//         
//         var admin = Db.Admins.FirstOrDefault(a => a.Login == body.Login);
//         if (admin is null) return NotFound(AdminId);
//         
//         if (body.Name is not null) admin.Name = body.Name;
//         if (body.Password is not null) admin.Password = body.Password;
//         if (body.Salt is not null) admin.Salt = body.Salt;
//         
//         await Db.SaveChangesAsync();
//         return Ok(admin.Id);
//     }
//     
//     [HttpDelete(ApiRoutes.Admin.Delete)]
//     public async Task<IActionResult> DeleteAdmin([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var admin = Db.Admins.FirstOrDefault(a => a.Id == AdminId);
//         if (admin is null) return Error(AdminId);
//         
//         Db.Admins.Remove(admin);
//         
//         await Save(Db);
//         return Ok();
//     }
// }