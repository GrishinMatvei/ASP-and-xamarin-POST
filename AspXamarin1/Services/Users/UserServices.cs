using Domain.Users;
using Services.Users.Models;

namespace Services.Users;

public class UsersServices
{
    private readonly UsersRepository _usersRepository;
    public UsersServices(ApplicationContext context)
    {
        _usersRepository = new UsersRepository(context);
    }

    public string SaveUser(UserBlank userBlank)
    {
        if (String.IsNullOrWhiteSpace(userBlank.Name))
            return "Не введено имя пользователя";

        if (String.IsNullOrWhiteSpace(userBlank.Fam))
            return "Не введена фамилия пользователя";

        userBlank.Id ??= _usersRepository.GetCount() + 1; 

        User? user = GetUser(userBlank.Id);

        if (user is null) _usersRepository.SaveUser(userBlank);
          
        return "Сохранение произошло успешно";
    }

    public User? GetUser(int? id)
    {
        if (id is null) return null;

        return _usersRepository.GetUser(id.Value);
    }
}
