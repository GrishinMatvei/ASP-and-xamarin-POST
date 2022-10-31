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

    [HttpPost("Users/SaveUser")]
    public string SaveUser([FromBody] UserDto userDto)
    {
        if (String.IsNullOrWhiteSpace(userDto.Name))
            return "Не введено имя пользователя";

        if (String.IsNullOrWhiteSpace(userDto.Fam))
            return "Не введена фамилия пользователя";

        var user = db.Users.FirstOrDefault(x => x.Id == userDto.Id);

        if (user is null)
        {
            User newUser = new User
            {
                Id = db.Users.Max(x => x.Id) + 1,
                Name = userDto.Name,
                Fam = userDto.Fam
            };

            db.Users.Add(newUser);
        }
        else
        {
            user.Name = userDto.Name;
            user.Fam = userDto.Fam;
        }

        int result = db.SaveChanges();

        if (result == 0) return "Пустой юзер, чувак";

        return "Сохранение произошло успешно";
    }
}
