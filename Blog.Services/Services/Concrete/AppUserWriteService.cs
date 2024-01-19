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
