using Domain.Users;
using Microsoft.AspNetCore.Mvc;
using Services.Users;
using Services.Users.Models;

namespace AspXamarin.Controllers;

public class UserController : ControllerBase
{
    private readonly UsersServices _usersService;
    public UserController(ApplicationContext context)
    { 
        _usersService = new UsersServices(context);
    }

    [HttpGet("Users/GetAll")]
    public User[] GetAllUsers()
    {
        return _usersService.GetUsers();
    }

    [HttpPost("Users/SaveUser")]
    public string SaveUser([FromBody] UserBlank userBlank)
    {
        return _usersService.SaveUser(userBlank);
    }
}
