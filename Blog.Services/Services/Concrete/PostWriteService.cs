using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Models.DTOs.Post;

namespace Blog.Application.Services.Concrete
{
    public class PostWriteService : IPostWriteService
    {
        private readonly IPostReadRepository _postReadRepository;
        private readonly IPostWriteRepository _postWriteRepository;
        private readonly IAuthorReadRepository _authorReadRepository;
        private readonly IGenreReadRepository _genreReadRepository;
        private readonly IMapper _mapper;

        public PostWriteService(IPostReadRepository postReadRepository, IPostWriteRepository postWriteRepository, IAuthorReadRepository authorReadRepository, IGenreReadRepository genreReadRepository, IMapper mapper)
        {
            _postReadRepository = postReadRepository;
            _postWriteRepository = postWriteRepository;
            _authorReadRepository = authorReadRepository;
            _genreReadRepository = genreReadRepository;
            _mapper = mapper;
        }

        public Task Create(PostCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<PostCreateDTO> CreatePost()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(PostUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
