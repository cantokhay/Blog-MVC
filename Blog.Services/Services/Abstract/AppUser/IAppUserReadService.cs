using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Abstract.AppUser
{
    public interface IAppUserReadService
    {
        Task<SignInResult> Login(LoginDTO model);
        Task Logout();
        Task<UpdateProfileDTO> GetByUserName(string userName);
    }
}
