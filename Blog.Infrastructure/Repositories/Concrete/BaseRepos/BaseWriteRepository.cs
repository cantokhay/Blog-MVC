using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract.BaseRepos;
using Blog.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Repositories.Concrete.BaseRepos
{
    public class BaseWriteRepository<T> : IBaseWriteRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        protected DbSet<T> table;

        public BaseWriteRepository(AppDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public async Task CreateReposAsync(T entity)
        {
            await table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReposAsync(T entity)
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReposAsync(T entity)
        {
            await _context.SaveChangesAsync();
        }
    }
}
