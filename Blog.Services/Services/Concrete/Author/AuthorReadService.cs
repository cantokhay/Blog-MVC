using Blog.Application.Services.Abstract.Author;
using Blog.Models.VMs;

namespace Blog.Application.Services.Concrete.Author
{
    public class AuthorReadService : IAuthorReadService
    {
        public Task<AuthorVM> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuthorVM>> GetAuthorList()
        {
            throw new NotImplementedException();
        }
    }
}
