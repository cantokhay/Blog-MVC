using Blog.Application.Services.Abstract.AppUser;
using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Concrete.AppUser
{
    public class AppUserWriteService : IAppUserWriteService
    {
        public Task<IdentityResult> Register(RegisterDTO model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(UpdateProfileDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
