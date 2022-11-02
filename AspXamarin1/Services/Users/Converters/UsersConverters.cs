using Domain.Users;
using Services.Users.Models;

namespace Services.Users.Converters;

internal static class UsersConverters
{
    public static User ToUser(this UserDb userDb)
    {
        return new User(userDb.Id, userDb.Name, userDb.Fam);
    }

    public static User[] ToUsers(this UserDb[] userDbs)
    {
        return userDbs.Select(db => db.ToUser()).ToArray();
    }
}
