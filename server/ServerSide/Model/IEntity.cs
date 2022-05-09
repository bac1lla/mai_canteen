using ServerSide.Contract.V1;

namespace ServerSide.Model;

public interface IGetEntity<out TGet> where TGet : Responses.Base.Entity.Get
{
    TGet Get();
}

public interface IEntity<out TGet, out TPartialGet> : IGetEntity<TGet>
    where TGet : Responses.Base.Entity.Get
    where TPartialGet : Responses.Base.Entity.PartialGet
{
    TPartialGet PartialGet();
}