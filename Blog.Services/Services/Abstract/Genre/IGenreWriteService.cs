using Blog.Models.DTOs.Genre;

namespace Blog.Application.Services.Abstract.Genre
{
    public interface IGenreWriteService
    {
        Task Create(GenreCreateDTO model);
        Task<GenreCreateDTO> CreateGenre();
        Task Update(GenreUpdateDTO model);
        Task Delete(int id);
    }
}
