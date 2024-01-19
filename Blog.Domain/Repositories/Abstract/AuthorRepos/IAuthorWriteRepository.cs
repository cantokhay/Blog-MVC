using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.BaseRepos;

namespace Blog.Domain.Repositories.Abstract.AuthorRepos
{
    public interface IAuthorWriteRepository : IBaseWriteRepository<Author>
    {
    }
}
