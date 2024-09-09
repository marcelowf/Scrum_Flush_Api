namespace ScrumFlush.Service.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
    }
}
