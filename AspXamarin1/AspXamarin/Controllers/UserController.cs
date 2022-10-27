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
    public string AddUser([FromBody] UserDto user)
    {
        if (String.IsNullOrWhiteSpace(user.Name))
            return "Не введено имя пользователя";

        if (String.IsNullOrWhiteSpace(user.Fam))
            return "Не введена фамилия пользователя";

        User newUser = new User
        {
            Id = db.Users.Max(x => x.Id) + 1,
            Name = user.Name,
            Fam = user.Fam
        };

        db.Users.Add(newUser);
        db.SaveChanges();

        var savedUser = db.Users.FirstOrDefault(x => x.Id == newUser.Id);

        if(savedUser is not null) return "Сохранение произошло успешно";

        return "Пустой юзер, чувак";
    }
}
