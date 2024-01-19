using AutoMapper;
using Blog.Application.Services.Abstract;
using Blog.Domain.Entities;
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

        public async Task Create(AuthorCreateDTO model)
        {
            Author author = _mapper.Map<Author>(model);
            author.CreateDate = DateTime.Now;
            author.Status = Domain.Enums.Status.Active;

            await _writeRepo.CreateReposAsync(author);
        }

        public async Task<AuthorCreateDTO> CreateAuthor()
        {
            return new AuthorCreateDTO();
        }

        public async Task Delete(int id)
        {
            Author author = await _readRepo.GetFirstOrDefault(x => x.ID == id);
            author.Status = Domain.Enums.Status.Deleted;
            author.DeleteDate = DateTime.Now;
            await _writeRepo.DeleteReposAsync(author);
        }

        public async Task Update(AuthorUpdateDTO model)
        {
            Author author = await _readRepo.GetFirstOrDefault(x => x.ID == model.ID);

            if (author != null)
            {
                author = _mapper.Map<Author>(model);
                author.UpdateDate = DateTime.Now;
                author.Status = Domain.Enums.Status.Modified;
            }

            await _writeRepo.UpdateReposAsync(author);
        }
    }
}
