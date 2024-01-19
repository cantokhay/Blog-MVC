using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.GenreRepos
{
    public class GenreWriteRepository : BaseWriteRepository<Genre>, IGenreWriteRepository
    {
        public GenreWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
