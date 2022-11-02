namespace Domain.Users;

public class User
{
    public int Id { get; }
    public string Name { get; }
    public string Fam { get; }

    public User(int id, string name, string fam)
    {
        Id = id;
        Name = name;
        Fam = fam;
    }
}
