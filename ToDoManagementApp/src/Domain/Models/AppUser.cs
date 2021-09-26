using Domain.Enums;

namespace Domain.Models
{
    public class AppUser
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AppRole Role { get; set; }
    }
}
