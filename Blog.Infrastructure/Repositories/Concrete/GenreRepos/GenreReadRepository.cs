using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.GenreRepos
{
    public class GenreReadRepository : BaseReadRepository<Genre>, IGenreReadRepository
    {
        public GenreReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
