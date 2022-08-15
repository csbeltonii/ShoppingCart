using Microsoft.EntityFrameworkCore;
using ShoppingCartExample.Data.Interfaces;

namespace ShoppingCartExample.Data
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        protected readonly Database _db;

        protected BaseRepository(Database db)
        {
            _db = db;
        }

        public abstract Task<TEntity?> Get(string id);

        public async Task<IEnumerable<TEntity>> GetAll() => await _db.Set<TEntity>()
                                                                     .ToListAsync()
                                                                     .ConfigureAwait(false);

        public async Task<TEntity> Add(TEntity entity)
        {
            var result = await _db.Set<TEntity>().AddAsync(entity).ConfigureAwait(false);

            await _db.SaveChangesAsync();

            return result.Entity;
        }

        public async Task Update(TEntity entity)
        {
            _db.Update(entity);

           await  _db.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _db.Remove(entity);

            await _db.SaveChangesAsync();
        }
    }
}
