using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Blog.Domain.Repositories.Abstract.BaseRepos
{
    public interface IBaseReadRepository<T> where T : class, IBaseEntity, new()
    {
        Task<bool> Any(Expression<Func<T, bool>> expression);

        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> expression);

        Task<List<T>> GetDefaultList(Expression<Func<T, bool>> expression);

        Task<TResult> GetFilteredFirstOrDefault<TResult>
            (Expression<Func<T, TResult>> select, //select = p => new PostDto { Title = p.Title, Id = p.Id }
            Expression<Func<T, bool>> where, //where = p => p.Id == id
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, //orderBy = p => p.OrderByDescending(p => p.Id)
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null); //Join

        Task<List<TResult>> GetFilteredList<TResult>
            (Expression<Func<T, TResult>> select, //select = p => new PostDto { Title = p.Title, Id = p.Id }
             Expression<Func<T, bool>> where, //where = p => p.Id == id
             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, //orderBy = p => p.OrderByDescending(p => p.Id)
             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null); //Join
    }
}
