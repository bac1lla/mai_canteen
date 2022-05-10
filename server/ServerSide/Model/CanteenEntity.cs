namespace ServerSide.Model;

public abstract class CanteenEntity : BaseEntity
{
    public string Name { init; get; }
    public string? Description { set; get; }
    public string? PhotoLocation { init; get; }

    protected CanteenEntity(string name, string? description, string? photoLocation)
        : base()
    {
        Name = name;
        Description = description;
        PhotoLocation = photoLocation;
    }
}