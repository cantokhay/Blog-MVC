using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract.Genre
{
    public interface IGenreReadService
    {
        Task<GenreVM> GetGenreById(int id);
        Task<List<GenreVM>> GetGenreList();
    }
}
