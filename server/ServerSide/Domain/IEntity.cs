namespace ServerSide.Domain;

public interface IEntityRequests<T>
{
        
}

public interface IEntityResponses<T>
{
        
}

public interface IEntity<TRequest, TResponse>  : IEntityRequests<TRequest>, IEntityResponses<TResponse>
{

}