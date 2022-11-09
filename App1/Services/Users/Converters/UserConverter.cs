using Domain.Users;
using Services.Users.Models;
using System.Linq;

namespace Services.Users.Converters
{
    public static class UserConverter
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
}
