using Domain.Users;
using Services.Users.Converters;
using Services.Users.Models;
using Tools.DataBase;

namespace Services.Users
{
    public class UsersService
    {
        public string SaveUser(UserBlank user)
        {
            return HttpClient.Post("Users/SaveUser", user);
        }

        public User[] GetUsers()
        {
            return HttpClient.Get<UserDb[]>("Users/GetAll").ToUsers();
        }

        public string DeleteUser(User user)
        {
            return HttpClient.Delete("Users/DeleteUser", user);
        }
    }
}

