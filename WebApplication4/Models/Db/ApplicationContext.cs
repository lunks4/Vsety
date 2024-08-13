using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models.Db
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public ApplicationContext() => Database.EnsureCreated();

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    }
}
