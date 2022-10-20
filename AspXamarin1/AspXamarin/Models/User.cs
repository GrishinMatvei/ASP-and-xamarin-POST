using System.ComponentModel.DataAnnotations;

namespace AspXamarin.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Fam { get; set; }

}
