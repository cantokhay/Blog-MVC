using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.BaseRepos;

namespace Blog.Domain.Repositories.Abstract.CommentRepos
{
    public interface ICommentReadRepository : IBaseReadRepository<Comment>
    {
    }
}
