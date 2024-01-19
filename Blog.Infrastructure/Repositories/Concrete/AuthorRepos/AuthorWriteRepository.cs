using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.AuthorRepos
{
    public class AuthorWriteRepository : BaseWriteRepository<Author>, IAuthorWriteRepository
    {
        public AuthorWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
