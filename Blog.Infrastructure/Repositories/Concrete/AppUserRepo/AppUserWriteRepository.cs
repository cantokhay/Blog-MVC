using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.AppUserRepo
{
    public class AppUserWriteRepository : BaseWriteRepository<AppUser>, IAppUserWriteRepository
    {
        public AppUserWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
