using Domain.Users;
using System.Collections.Generic;
using Tools.DataBase;

namespace Services.Users
{
    public class UsersService
    {
        public string SaveUser(UserBlank user)
        {
            return HttpClient.Post("Users/SaveUser", user);
        }

        public List<User> GetUsers()
        {
            return HttpClient.Get("Users/GetAll");
        }
    }
}

