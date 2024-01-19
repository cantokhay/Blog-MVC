using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.AuthorRepos
{
    public class AuthorReadRepository : BaseReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
