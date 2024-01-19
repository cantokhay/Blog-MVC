using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.PostRepos
{
    public class PostReadRepository : BaseReadRepository<Post>, IPostReadRepository
    {
        public PostReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
