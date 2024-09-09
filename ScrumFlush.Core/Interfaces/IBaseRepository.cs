namespace ScrumFlush.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
    }
}
