namespace ServerSide.Static;

public static class StaticContext
{
    public class StaticElementNotFoundException : Exception
    {
        public string Location { init; get; }
        // public string Url { init; get; } = StaticContext.GetUrl(Location);
    }
    
    private static List<string> Elements { set; get; } = 
        Directory.GetFiles(Directory.GetCurrentDirectory()).ToList();

    public static void AddElement(string location) => Elements.Add(location);

    public static void AddPhoto(string location, object photo)
    {
        WebImage.
        AddElement(location);
    }
    
    public static string GetUrl(string PhotoLocation) => ""; // TODO

    public static bool Find(string location) => Elements.Contains(location);
}