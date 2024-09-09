namespace ScrumFlush.Application.Interfaces
{
    public interface IBaseApplicationService<TEntity> where TEntity : class
    {
        Task<IList<TEntity>> GetAll();
    }
}
