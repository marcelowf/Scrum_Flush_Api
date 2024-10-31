using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TFilters> : IBaseRepository<TEntity, TFilters>
        where TEntity : class
        where TFilters : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }
 
        // TODO: Add Filter
        public async Task<IList<TEntity>> GetAll(TFilters filters)
        {
            return await this.sqlContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await this.sqlContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Create(Guid authorId, TEntity entity)
        {
            await this.sqlContext.Set<TEntity>().AddAsync(entity);
            await this.sqlContext.SaveChangesAsync(authorId);
            return entity;
        }

        public async Task<TEntity> Update(Guid authorId, Guid id, TEntity entity)
        {
            var existingEntity = await GetById(id);
            if (existingEntity == null)
            {
                return null;
            }

            this.sqlContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            await this.sqlContext.SaveChangesAsync(authorId);
            return entity;
        }

        public async Task<bool> Delete(Guid id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            this.sqlContext.Set<TEntity>().Remove(entity);
            return true;
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                return false;
            }

            var property = typeof(TEntity).GetProperty("IsDeleted");
            if (property != null)
            {
                property.SetValue(entity, true);
                this.sqlContext.Entry(entity).State = EntityState.Modified;
                await this.sqlContext.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
