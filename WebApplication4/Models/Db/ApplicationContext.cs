using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models.Db
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Password = "Tom", Name = new Person() },
                    new User { Id = 2, Password = "Bob", Name = new Person() },
                    new User { Id = 3, Password = "Sam", Name = new Person() }
            );
        }
    }
}
