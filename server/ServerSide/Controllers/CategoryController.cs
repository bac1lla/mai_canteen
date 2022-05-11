using Microsoft.AspNetCore.Mvc;
using ServerSide.Contract.V1;
using ServerSide.Data;
using ServerSide.Model.ModelExtensions;

namespace ServerSide.Controllers;

// public class CategoryController : BaseController
// {
//     private DataContext Db { set; get; }
//     
//     public CategoryController(DataContext dataContext) => Db = dataContext;
//
//     [HttpGet(ApiRoutes.Category.Get)]
//     public IActionResult Get([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var category = Db.Categories.FirstOrDefault(c => c.Id == AdminId);
//         
//         return category is null ? NotFound(AdminId) : Ok(category.Get());
//     }
//     
//     [HttpGet(ApiRoutes.Category.PartialGet)]
//     public IActionResult PartialGet([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var category = Db.Categories.FirstOrDefault(c => c.Id == AdminId);
//         
//         return category is null ? NotFound(AdminId) : Ok(category.PartialGet());
//     }
//     
//     [HttpPost(ApiRoutes.Category.Create)]
//     public async Task<IActionResult> Create([FromBody] Requests.Category.Create body)
//     {
//         // Auth here
//         
//         var existingAdmin = Db.Categories.FirstOrDefault(c => c.Name == body.Name);
//         if (existingAdmin is null) return Exists(body);
//         
//         var category = await Db.Categories.AddAsync(body.Create());
//         
//         await Db.SaveChangesAsync();
//         return Ok(category.Entity.Id);
//     }
//     
//     [HttpPost(ApiRoutes.Category.Update)]
//     public async Task<IActionResult> Update([FromRoute] string AdminId, [FromBody] Requests.Base.User.Update body)
//     {
//         // Auth here
//         
//         var category = Db.Categories.FirstOrDefault(c => c.Name == body.Name);
//         if (category is null) return NotFound(AdminId);
//         
//         // if (body.Name is not null) category.Name = body.Name;
//         // if (body.Password is not null) category.Password = body.Password;
//         // if (body.Salt is not null) category.Salt = body.Salt;
//         
//         await Db.SaveChangesAsync();
//         return Ok(category.Id);
//     }
//     
//     [HttpDelete(ApiRoutes.Category.Delete)]
//     public async Task<IActionResult> Delete([FromRoute] string AdminId)
//     {
//         // Auth here
//         
//         var category = Db.Categories.FirstOrDefault(c => c.Id == AdminId);
//         if (category is null) return Error(AdminId);
//         
//         Db.Categories.Remove(category);
//         
//         await Save(Db);
//         return Ok();
//     }
// }