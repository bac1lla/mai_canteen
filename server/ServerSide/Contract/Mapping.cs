namespace ServerSide.Contract;

public enum AuthorizationLevel
{
    None,
    User,
    Admin, 
    SuperUser
}

public record struct Mapping(
    string Route, 
    Type Request, 
    Type Response, 
    AuthorizationLevel MinimalAuthorizationLevel = AuthorizationLevel.User
);