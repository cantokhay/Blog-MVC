using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.LikeRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.LikeRepos
{
    public class LikeReadRepository : BaseReadRepository<Like>, ILikeReadRepository
    {
        public LikeReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
