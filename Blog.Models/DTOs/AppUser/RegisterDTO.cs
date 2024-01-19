using Blog.Domain.Enums;

namespace Blog.Models.DTOs.AppUser
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }
    }
}
