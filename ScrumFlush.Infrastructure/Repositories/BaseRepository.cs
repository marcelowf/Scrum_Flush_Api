using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public BaseRepository(SqlContext _sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await this.sqlContext.Set<TEntity>().ToListAsync();
        }
    }
}
