using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.LikeRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class LikeReadService : ILikeReadService
    {
        private readonly ILikeReadRepository _likeReadRepository;
        private readonly IAppUserReadRepository _appUserReadRepository;
        private readonly IPostReadRepository _postReadRepository;
        private readonly IMapper _mapper;

        public LikeReadService(ILikeReadRepository likeReadRepository, IAppUserReadRepository appUserReadRepository, IPostReadRepository postReadRepository, IMapper mapper)
        {
            _likeReadRepository = likeReadRepository;
            _appUserReadRepository = appUserReadRepository;
            _postReadRepository = postReadRepository;
            _mapper = mapper;
        }

        public Task<LikeVM> GetLikeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LikeVM>> GetLikeList()
        {
            throw new NotImplementedException();
        }
    }
}
