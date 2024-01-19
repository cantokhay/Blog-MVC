using Blog.Models.VMs;

namespace Blog.Application.Services.Abstract.Author
{
    public interface IAuthorReadService
    {
        Task<AuthorVM> GetAuthorById(int id);
        Task<List<AuthorVM>> GetAuthorList();
    }
}
