using Domain.Users;
using Services.Users.Converters;
using Services.Users.Models;

namespace Services.Users;

public class UsersRepository
{
    private readonly ApplicationContext _context;
    public UsersRepository(ApplicationContext context)
    {
        _context = context;
    }

    public void SaveUser(UserBlank userBlank)
    {
        UserDb db = new UserDb(userBlank.Id.Value, userBlank.Name, userBlank.Fam);
        _context.Add(db);
        _context.SaveChanges();
    }

    public User? GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id)?.ToUser() ?? null;
    }

    public int GetCount()
    {
        return _context.Users.Max(x => x.Id);
    }
}
