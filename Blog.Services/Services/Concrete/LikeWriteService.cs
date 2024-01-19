using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.LikeRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.DTOs.Like;

namespace Blog.Application.Services.Concrete
{
    public class LikeWriteService : ILikeWriteService
    {
        private readonly ILikeReadRepository _likeReadRepository;
        private readonly ILikeWriteRepository _likeWriteRepository;
        private readonly IAppUserReadRepository _appUserReadRepository;
        private readonly IPostReadRepository _postReadRepository;
        private readonly IMapper _mapper;

        public LikeWriteService(ILikeReadRepository likeReadRepository, ILikeWriteRepository likeWriteRepository, IAppUserReadRepository appUserReadRepository, IPostReadRepository postReadRepository, IMapper mapper)
        {
            _likeReadRepository = likeReadRepository;
            _likeWriteRepository = likeWriteRepository;
            _appUserReadRepository = appUserReadRepository;
            _postReadRepository = postReadRepository;
            _mapper = mapper;
        }

        public Task Create(LikeCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<LikeCreateDTO> CreateLike()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(LikeUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
