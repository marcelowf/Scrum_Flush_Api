using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumFlush.Service.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(Guid id, TEntity entity);
        Task<bool> Delete(Guid id);
        Task<bool> SoftDelete(Guid id);
    }
}
