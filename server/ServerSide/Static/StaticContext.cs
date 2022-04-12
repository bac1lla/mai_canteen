namespace ServerSide.Static;

public static class StaticContext
{
    // public static string GetElement() { }
}

public class StaticElementNotFoundException : Exception
{
    public string StaticElementLocation { set; get; }
}