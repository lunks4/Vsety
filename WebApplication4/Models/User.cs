using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class User
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
    }
}
