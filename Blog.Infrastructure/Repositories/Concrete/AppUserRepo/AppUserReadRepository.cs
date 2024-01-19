using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.AppUserRepo
{
    public class AppUserReadRepository : BaseReadRepository<AppUser>, IAppUserReadRepository
    {
        public AppUserReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
