namespace ServerSide.Model;

public abstract class CanteenEntity : BaseEntity
{
    public string Name { set; get; }
    public string? Description { set; get; }
    public string? PhotoLocation { set; get; }
}