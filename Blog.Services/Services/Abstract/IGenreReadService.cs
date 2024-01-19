using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract
{
    public interface IGenreReadService
    {
        Task<GenreVM> GetGenreById(int id);
        Task<List<GenreVM>> GetGenreList();
    }
}
