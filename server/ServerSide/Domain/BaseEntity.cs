using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ServerSide.Contract.V1;

namespace ServerSide.Domain;

public abstract record BaseEntity
{
    public static string NewId() => Guid.NewGuid().ToString();

    public static IEnumerable<string> IdsOnly(IEnumerable<BaseEntity> entities) => 
        entities.Select(e => e.Id);

    [Key] 
    public string Id { set; get; } = NewId();
    
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { set; get; } = DateTime.Now;
    
    public bool IsDeleted { set; get; } = false;
}