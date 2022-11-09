using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Services.Users.Models;

public class ApplicationContext : DbContext
{
    public DbSet<UserDb> Users { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}
