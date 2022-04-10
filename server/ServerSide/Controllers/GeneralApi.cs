using Microsoft.AspNetCore.Mvc;
using ServerSide.Data;

namespace ServerSide.Controllers;

[Route("general")]
public class GeneralApi : Controller
{
    private DataContext Db { set; get; }
    public GeneralApi(DataContext db) => Db = db;
    
    
    [HttpGet("meals/all")]
    public IActionResult GetMeals() => Ok(Db.Meals);
    
    [HttpGet("meals/{restaurantId}")]
    public IActionResult GetMealsByRestaurant(string restaurantId) => 
        Ok(Db.Meals.Where(meal => meal.ResaturantId == restaurantId));

    [HttpGet("meals/{categoryId}")]
    public IActionResult GetMealsByCategory(string categoryId) =>
        Ok(Db.Meals.Where(meal => meal.CategoryId == categoryId));
    
    [HttpGet("meals/{restaurantId, categoryId}")]
    public IActionResult GetMealsByRestaurantAndCategory(string restaurantId, string categoryId) =>
        Ok(Db.Meals.Where(meal => meal.ResaturantId == restaurantId && meal.CategoryId == categoryId));

    [HttpGet("categories/all")]
    public IActionResult GetCategories() => Ok(Db.Categories);

    [HttpGet("categories/{restaurantId}")]
    public IActionResult GetCategories(string restaurantId) => 
        Ok(Db.Restaurants.Find(restaurantId)?.Meals.Select(meal => meal.Category));
}