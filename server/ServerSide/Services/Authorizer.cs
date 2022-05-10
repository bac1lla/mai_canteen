﻿using ServerSide.Data;
using ServerSide.Model;
using ServerSide.Model.ModelExtensions;
using Helpers = ServerSide.Model.ModelExtensions.ModelHelpersAndBasicExtensions;

namespace ServerSide.Services;

public interface IAuthorizer
{
    bool IsAuthorizedUser(BaseUser user);
    bool IsAuthorizedId(string userId);
    bool IsAuthorizedToken(string tokenValue);

    bool RefreshTokenUser(BaseUser user);
    bool RefreshTokenId(string userId);
    bool RefreshToken(string tokenValue);
}

public class Authorizer : IAuthorizer
{
    private DataContext Db { init; get; }

    public Authorizer(DataContext db) => Db = db;

    public bool IsAuthorizedUser(BaseUser user) => IsAuthorizedId(user.Id);
    public bool IsAuthorizedId(string userId)
    {
        var user = Db.AllUsers.Find(userId);
        return user is not null && user.IsAuthorized();
    }
    public bool IsAuthorizedToken(string tokenValue)
    {
        var user = Db.AllUsers.FirstOrDefault(u => u.TokenValue == tokenValue);
        return user is not null && user.TokenIsValid();
    }

    public bool RefreshTokenUser(BaseUser user) => RefreshTokenId(user.Id);
    public bool RefreshTokenId(string userId)
    {
        var user = Db.AllUsers.Find(userId);
        if (user is null) return false;

        if (user.TokenIsValid()) user.TokenRefresh();
        else user.NewToken();
        
        return true;
    }
    public bool RefreshToken(string tokenValue)
    {
        var user = Db.AllUsers.FirstOrDefault(u => u.TokenValue == tokenValue);
        if (user is null) return false;

        if (user.TokenIsValid()) user.TokenRefresh();
        else user.NewToken();
        
        return true;
    }
}