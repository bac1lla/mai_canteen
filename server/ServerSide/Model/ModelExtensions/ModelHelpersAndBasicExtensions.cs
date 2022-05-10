using System.Text;

namespace ServerSide.Model.ModelExtensions;

public static class ModelHelpersAndBasicExtensions
{
    public static string NewId() => Guid.NewGuid().ToString();
    
    public static bool IsAuthorized(this BaseUser user) => user.TokenIsValid();
    public static string NameToShow(this BaseUser user) => user.Name ?? user.Login;

    public static IEnumerable<string> IdsOnly(IEnumerable<BaseEntity> entities) => 
        entities.Select(e => e.Id);

    // TODO: remove placeholder
    public static string NewTokenValue(BaseUser user) => new StringBuilder()
        .Append(user.Role).Append("__")
        .Append(user.Id).Append("__")
        .Append(DateTime.Now)
        .ToString();

    public static void NewToken(this BaseUser user)
    {
        user.TokenValue = NewTokenValue(user);
        user.TokenExpirationDate = DateTime.Now.Add(TokenExpirationInterval);
    }

    public static readonly TimeSpan TokenExpirationInterval = new(7, 0, 0, 0);
    public static void TokenRefresh(this BaseUser user) => 
        user.TokenExpirationDate = DateTime.Now + TokenExpirationInterval;
    public static bool TokenIsValid(this BaseUser user) => 
        DateTime.Now <= user.TokenExpirationDate;
    
    public static IEnumerable<Restaurant> Restaurants(this Category category) => 
        category.Meals.Select(m => m.Restaurant).Distinct();

    public static decimal? MealPriceValue(this Meal meal) => meal.CurrentPrice?.Value;

    public static bool IsFinished(this Order order) => order.EndDate is not null;
}