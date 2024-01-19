using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Abstract.AppUser
{
    public interface IAppUserWriteService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task UpdateUser(UpdateProfileDTO model);
    }
}
