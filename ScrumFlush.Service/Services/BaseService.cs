using ScrumFlush.Core.Interfaces;
using ScrumFlush.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<TEntity> GetById(Guid id)
        {
            return await repository.GetById(id);
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            return await repository.Create(entity);
        }

        public async Task<TEntity> Update(Guid id, TEntity entity)
        {
            return await repository.Update(id, entity);
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
