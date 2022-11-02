namespace Services.Users.Models;

public class UserDb
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Fam { get; set; }

    public UserDb(int id, string name, string fam)
    {
        Id = id;
        Name = name;
        Fam = fam;
    }
}
