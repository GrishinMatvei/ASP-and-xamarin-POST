using Domain.Users;
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
            return HttpClient.Get<User[]>("Users/GetAll");
        }
    }
}

