using Microsoft.EntityFrameworkCore;

namespace ServerSide.Model;

[Index(nameof(Name))]
public abstract class CanteenEntity : BaseEntity
{
    public string Name { set; get; }
    public string? Description { set; get; }
    public string? PhotoLocation { set; get; }
}