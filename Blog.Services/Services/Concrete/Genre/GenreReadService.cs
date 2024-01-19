using Blog.Application.Services.Abstract.Genre;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete.Genre
{
    public class GenreReadService : IGenreReadService
    {
        public Task<GenreVM> GetGenreById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GenreVM>> GetGenreList()
        {
            throw new NotImplementedException();
        }
    }
}
