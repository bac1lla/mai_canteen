using Responses = ServerSide.Contract.V1.Responses;

namespace ServerSide.Model.ModelExtensions;

public static class ModelToPartialGetResponseExtensions
{
    public static Responses.Base.User.PartialGet PartialGet(this BaseUser user) => new(user);
    public static Responses.Admin.PartialGet PartialGet(this Admin admin) => new(admin);
    public static Responses.User.PartialGet PartialGet(this User user) => new(user);

    public static Responses.Price.PartialGet PartialGet(this Price price) => new(price);
    
    public static Responses.Restaurant.PartialGet PartialGet(this Restaurant restaurant) => new(restaurant);
    public static Responses.Category.PartialGet PartialGet(this Category category) => new(category);
    public static Responses.Meal.PartialGet PartialGet(this Meal meal) => new(meal);

    public static Responses.Order.PartialGet PartialGet(this Order order) => new(order);
    // public static Responses.Order.Item PartialGet(this Order.Item item) => new(item);
}