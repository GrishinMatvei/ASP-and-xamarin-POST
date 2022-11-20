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

    public void SaveUser(UserBlank userBlank, bool isNew)
    {
        UserDb db = new UserDb(userBlank.Id.Value, userBlank.Name, userBlank.Fam);
        if(isNew) _context.Add(db); else
        {
            db.Name = userBlank.Name;
            db.Fam = userBlank.Fam;
        }
        _context.SaveChanges();
    }

    public User? GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id)?.ToUser() ?? null;
    }

    public User[] GetUsers()
    {
        return _context.Users.ToArray().ToUsers();
    }

    public int GetCount()
    {
        return _context.Users.Max(x => x.Id);
    }

    public void DeleteUser(int id)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == id)?.ToUser() ?? null;
        _context.Remove(user);
        _context.SaveChanges();         
    }
}
