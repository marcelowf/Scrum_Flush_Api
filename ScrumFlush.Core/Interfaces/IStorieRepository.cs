using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Core.Interfaces
{
    public interface IStorieRepository : IBaseRepository<Storie, StorieFilter>
    {
        
    }
}
