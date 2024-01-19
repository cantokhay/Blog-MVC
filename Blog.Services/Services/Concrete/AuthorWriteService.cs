using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Models.DTOs.Author;

namespace Blog.Application.Services.Concrete
{
    public class AuthorWriteService : IAuthorWriteService
    {
        private readonly IAuthorReadRepository _readRepo;
        private readonly IAuthorWriteRepository _writeRepo;
        private readonly IMapper _mapper;

        public AuthorWriteService(IAuthorReadRepository readRepo, IAuthorWriteRepository writeRepo, IMapper mapper)
        {
            _readRepo = readRepo;
            _writeRepo = writeRepo;
            _mapper = mapper;
        }

        public Task Create(AuthorCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorCreateDTO> CreateAuthor()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AuthorUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
