using System.ComponentModel.DataAnnotations;

namespace ServerSide.Model;

public abstract class BaseEntity
{
    public static string NewId() => Guid.NewGuid().ToString();

    public static IEnumerable<string> IdsOnly(IEnumerable<BaseEntity> entities) => 
        entities.Select(e => e.Id);

    [Key] 
    public string Id { init; get; } = NewId();
    
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { init; get; } = DateTime.Now;
    
    public bool IsDeleted { set; get; } = false;
}