using CleanArchitecure.Domain.Entities;
using CleanArchitecure.Domain.Interfaces;
using CleanArchitecure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecure.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }
        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDelete = DateTimeOffset.UtcNow;
            Context.Remove(entity);
        }

        public async Task<T> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }
    }
}
