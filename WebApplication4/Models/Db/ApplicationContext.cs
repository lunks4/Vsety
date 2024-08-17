using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models.Db
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Person> Persons { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;port=3306;Database=db_vsety;User=root;Password=admin;",
                    new MySqlServerVersion(new Version(8, 0, 21)));

            }
        }
    }
}
