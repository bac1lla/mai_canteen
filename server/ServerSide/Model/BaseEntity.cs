using Helpers = ServerSide.Model.ModelExtensions;
using System.ComponentModel.DataAnnotations;

namespace ServerSide.Model;

public abstract class BaseEntity
{
    [Key] 
    public string Id { init; get; }
    
    [DataType(DataType.DateTime)]
    public DateTime CreationDate { init; get; }
    
    public bool IsDeleted { set; get; } 

    protected BaseEntity() 
        : this(Helpers.ModelHelpersAndBasicExtensions.NewId()) 
    { }

    protected BaseEntity(string id) 
        : this(id, DateTime.Now, false) 
    { }

    protected BaseEntity(string id, DateTime creationDate, bool isDeleted)
    {
        Id = id;
        CreationDate = creationDate;
        IsDeleted = isDeleted;
    }
}