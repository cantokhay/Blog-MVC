using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Abstract
{
    public interface IAppUserWriteService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task UpdateUser(UpdateProfileDTO model);
    }
}
