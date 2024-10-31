using ScrumFlush.Core.Interfaces;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class BaseService<TEntity, TFilters> : IBaseService<TEntity, TFilters>
        where TEntity : class
        where TFilters : class
    {
        private readonly IBaseRepository<TEntity, TFilters> repository;

        public BaseService(IBaseRepository<TEntity, TFilters> repository)
        {
            this.repository = repository;
        }

        public async Task<IList<TEntity>> GetAll(TFilters filters)
        {
            return await repository.GetAll(filters);
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await repository.GetById(id);
        }

        public async Task<TEntity> Create(Guid authorId, TEntity entity)
        {
            return await repository.Create(authorId, entity);
        }

        public async Task<TEntity> Update(Guid authorId, Guid id, TEntity entity)
        {
            return await repository.Update(authorId, id, entity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await repository.Delete(id);
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            return await repository.SoftDelete(id);
        }
    }
}
