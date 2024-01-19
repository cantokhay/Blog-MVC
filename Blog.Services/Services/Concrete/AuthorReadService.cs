using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete
{
    public class AuthorReadService : IAuthorReadService
    {
        private readonly IAuthorReadRepository _readRepo;
        private readonly IMapper _mapper;

        public AuthorReadService(IAuthorReadRepository readRepo, IMapper mapper)
        {
            _readRepo = readRepo;
            _mapper = mapper;
        }

        public Task<AuthorVM> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorVM>> GetAuthorList()
        {
            throw new NotImplementedException();
        }
    }
}
