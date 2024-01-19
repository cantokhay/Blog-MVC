using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Models.DTOs.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Services.Concrete
{
    public class AppUserWriteService : IAppUserWriteService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IAppUserReadRepository _readRepo;
        private readonly IAppUserWriteRepository _writeRepo;

        public AppUserWriteService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IMapper mapper, IAppUserReadRepository readRepo, IAppUserWriteRepository writeRepo)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _readRepo = readRepo;
            _writeRepo = writeRepo;
        }

        public async Task<IdentityResult> Register(RegisterDTO model)
        {
            AppUser user = _mapper.Map<AppUser>(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
                await _signInManager.SignInAsync(user, false);
            return result;
        }

        public async Task UpdateUser(UpdateProfileDTO model)
        {
            if (await _readRepo.Any(x => x.Id == model.Id))
            {
                AppUser user = _mapper.Map<AppUser>(model);
                await _writeRepo.UpdateReposAsync(user);

                if(model.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                    await _writeRepo.UpdateReposAsync(user);
                }

                if(model.Email != null)
                {
                    AppUser isUserMailExist = await _userManager.FindByEmailAsync(model.Email);
                    await _userManager.SetUserNameAsync(user, model.UserName);

                    if (isUserMailExist == null)
                        await _userManager.SetEmailAsync(user, model.Email);
                }
            }
        }
    }
}
