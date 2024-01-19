using Blog.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Blog.Models.DTOs.AppUser
{
    public class UpdateProfileDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public string Email { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
    }
}
