using Blog.Application.Services.Abstract.AppUser;
using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Concrete.AppUser
{
    public class AppUserReadService : IAppUserReadService
    {
        public Task<UpdateProfileDTO> GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> Login(LoginDTO model)
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }
    }
}
