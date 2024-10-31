using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Core.Interfaces
{
    public interface IVoteRepository : IBaseRepository<Vote, VoteFilter>
    {
        
    }
}
