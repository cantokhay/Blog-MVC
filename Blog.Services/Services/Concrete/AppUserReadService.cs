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
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IAppUserReadRepository _readRepo;

        public AppUserReadService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IMapper mapper, IAppUserReadRepository readaRepo)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _readRepo = readaRepo;
        }

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
