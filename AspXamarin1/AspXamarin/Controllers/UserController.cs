using AspXamarin.Models;
using AspXamarin.Models.ApplicationContext;
using Microsoft.AspNetCore.Mvc;

namespace AspXamarin.Controllers;
 
public class UserController : ControllerBase
{
    ApplicationContext db;
    public UserController(ApplicationContext context)
    {
        db = context;
    }

    [HttpGet("Users/GetAll")]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(db.Users.ToList());
    }

    [HttpPost("Users/CreateUser")]
    public async Task<IActionResult> AddUser([FromBody] UserDto user)
    {
        if (user != null)
        {
            User newUser = new User
            {
                Id = db.Users.Max(x => x.Id) + 1,
                Name = user.Name,
                Fam = user.Fam
            };

            db.Users.Add(newUser);
            await db.SaveChangesAsync();
            return Ok("Сохранение произошло успешно");
        }

        return BadRequest("Пустой юзер, чувак"); 
    }

}
