using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.CommentRepos;
using Blog.Infrastructure.Context;
using Blog.Infrastructure.Repositories.Concrete.BaseRepos;

namespace Blog.Infrastructure.Repositories.Concrete.CommentRepos
{
    public class CommentReadRepository : BaseReadRepository<Comment>, ICommentReadRepository
    {
        public CommentReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
