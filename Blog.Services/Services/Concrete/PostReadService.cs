using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class PostReadService : IPostReadService
    {
        private readonly IPostReadRepository _postReadRepository;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IGenreReadRepository _genreReadRepository;
        private readonly IMapper _mapper;

        public PostReadService(IPostReadRepository postReadRepository, IAuthorReadRepository authorReadRepository, IGenreReadRepository genreReadRepository, IMapper mapper)
        {
            _postReadRepository = postReadRepository;
            _authorReadRepository = authorReadRepository;
            _genreReadRepository = genreReadRepository;
            _mapper = mapper;
        }

        public Task<PostVM> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PostVM> GetPostDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostVM>> GetPostList()
        {
            throw new NotImplementedException();
        }
    }
}
