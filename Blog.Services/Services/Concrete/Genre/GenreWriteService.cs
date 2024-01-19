using Blog.Application.Services.Abstract.Genre;
using Blog.Models.DTOs.Genre;

namespace Blog.Application.Services.Concrete.Genre
{
    public class GenreWriteService : IGenreWriteService
    {
        public Task Create(GenreCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<GenreCreateDTO> CreateGenre()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(GenreUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
