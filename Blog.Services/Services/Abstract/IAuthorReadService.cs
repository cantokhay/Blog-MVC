using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract
{
    public interface IAuthorReadService
    {
        Task<AuthorVM> GetAuthorById(int id);
        Task<List<AuthorVM>> GetAuthorList();
    }
}
