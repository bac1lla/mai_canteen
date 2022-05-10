using Responses = ServerSide.Contract.V1.Responses;

namespace ServerSide.Model.ModelExtensions;

public static class ModelToGetResponseExtensions
{
    public static Responses.Base.User.Get Get(this BaseUser user) => new(user);
    public static Responses.Admin.Get Get(this Admin admin) => new(admin);
    public static Responses.User.Get Get(this User user) => new(user);

    public static Responses.Price.Get Get(this Price price) => new(price);
    
    public static Responses.Restaurant.Get Get(this Restaurant restaurant) => new(restaurant);
    public static Responses.Category.Get Get(this Category category) => new(category);
    public static Responses.Meal.Get Get(this Meal meal) => new(meal);

    public static Responses.Order.Get Get(this Order order) => new(order);
    public static Responses.Order.Item Get(this Order.Item item) => new(item);
}