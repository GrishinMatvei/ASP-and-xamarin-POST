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

    //[HttpGet("Users/GetAll")]
    //public async Task<IActionResult> GetAllUsers()
    //{
    //    return Ok(db.Users.ToList());
    //}

    [HttpPost("Users/SaveUser")]
    public string SaveUser([FromBody] UserBlank userBlank)
    {
        return _usersService.SaveUser(userBlank);
    }
}
