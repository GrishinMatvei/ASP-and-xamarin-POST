namespace Domain.Users;

public class UserBlank
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Fam { get; set; }

    public UserBlank(int? id, string name, string fam)
    {
        Id = id;
        Name = name;
        Fam = fam;
    }
}
