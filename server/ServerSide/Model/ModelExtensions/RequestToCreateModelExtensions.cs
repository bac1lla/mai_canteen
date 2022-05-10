using ServerSide.Data;
using Requests = ServerSide.Contract.V1.Requests;

namespace ServerSide.Model.ModelExtensions;

public static class RequestToModelExtensions
{
    private static DataContext Db { set; get; }

    // public static SuperUser Create(this Requests.Base.User.Create user) =>
    //     new(user.Login, user.Name, user.Password, user.Salt);
    
    public static Admin Create(this Requests.Admin.Create admin) => 
        new(admin.Login, admin.Name!, admin.Password, admin.Salt, 
            Db.Restaurants.Find(admin.RestaurantId)!);
    
    public static User Create(this Requests.Base.User.Create user) => 
        new(user.Login, user.Name, user.Password, user.Salt);

    public static Category Create(this Requests.Category.Create category) =>
        new(category.Name, category.Description, category.PhotoLocation);

    public static Restaurant Create(this Requests.Restaurant.Create restaurant) =>
        new(restaurant.Name, restaurant.Description, restaurant.PhotoLocation);

    public static Meal Create(this Requests.Meal.Create meal)
    {
        var createdMeal = new Meal(meal.Name, meal.Description, meal.PhotoLocation, 
            meal.Ingredients,
            Db.Categories.Find(meal.CategoryId)!,
            Db.Restaurants.Find(meal.RestaurantId)!, 
            null);

        var createdPrice = new Price(meal.PriceValue, createdMeal);
        createdMeal.CurrentPrice = createdPrice;
        createdMeal.Prices = new List<Price>() { createdPrice };

        return createdMeal;
    }

    private static Order.Item Create(this Requests.Order.Item item, Order order) =>
        new(order, Db.Meals.Find(item.MealId)!, item.Count);
    
    public static Order Create(this Requests.Order.Create order)
    {
        var createdOrder = new Order(
            null,
            Db.Restaurants.Find(order.RestaurantId)!,
            Db.Users.Find(order.UserId)!
        );

        var createdItems = order.OrderItems.Select(i => i.Create(createdOrder));
        createdOrder.Items = createdItems;

        return createdOrder;
    }
}