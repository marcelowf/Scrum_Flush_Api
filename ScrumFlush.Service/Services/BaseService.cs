using ScrumFlush.Core.Interfaces;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await repository.GetAll();
        }
    }
}