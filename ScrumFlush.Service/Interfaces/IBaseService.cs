namespace ScrumFlush.Service.Interfaces
{
    public interface IBaseService<TEntity, TFilters> where TEntity : class
    {
        Task<IList<TEntity>> GetAll(TFilters filters);
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Create(Guid authorId, TEntity entity);
        Task<TEntity> Update(Guid authorId, Guid id, TEntity entity);
        Task<bool> Delete(Guid id);
        Task<bool> SoftDelete(Guid id);
    }
}
