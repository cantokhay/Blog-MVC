using Blog.Application.Services.Abstract.Author;
using Blog.Models.DTOs.Author;

namespace Blog.Application.Services.Concrete.Author
{
    public class AuthorWriteService : IAuthorWriteService
    {
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
