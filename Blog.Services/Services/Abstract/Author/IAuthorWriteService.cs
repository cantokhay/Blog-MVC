using Blog.Models.DTOs.Author;

namespace Blog.Application.Services.Abstract.Author
{
    public interface IAuthorWriteService
    {
        Task Create(AuthorCreateDTO model);
        Task<AuthorCreateDTO> CreateAuthor();
        Task Update(AuthorUpdateDTO model);
        Task Delete(int id);
    }
}
