using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Blog.Domain.Entities;
using Blog.Application.Services.Abstract;
using Blog.Models.DTOs.AppUser;
using Blog.Domain.Repositories.Abstract.AppUserRepos;

namespace Blog.Application.Services.Concrete
{
    public class AppUserReadService : IAppUserReadService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IAppUserReadRepository _readRepo;

        public AppUserReadService(SignInManager<AppUser> signInManager, IAppUserReadRepository readaRepo)
        {
            _signInManager = signInManager;
            _readRepo = readaRepo;
        }

        public async Task<UpdateProfileDTO> GetByUserName(string userName)
        {
            UpdateProfileDTO user = await _readRepo.GetFilteredFirstOrDefault(
                                            select: x => new UpdateProfileDTO
                                            {
                                                Id = x.Id,
                                                UserName = x.UserName,
                                                Email = x.Email,
                                                Password = x.PasswordHash,
                                            },
                                            where: x => x.UserName == userName);

            return user;
        }

        public Task<SignInResult> Login(LoginDTO model)
        {
            return _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
        }

        public Task Logout()
        {
            return _signInManager.SignOutAsync();
        }
    }
}
