using Blog.Domain.Entities;

namespace Blog.Domain.Repositories.Abstract.BaseRepos
{
    public interface IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        Task CreateReposAsync(T entity);

        Task UpdateReposAsync(T entity);

        Task DeleteReposAsync(T entity);
    }
}
