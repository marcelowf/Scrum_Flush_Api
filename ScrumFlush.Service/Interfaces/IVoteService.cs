using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Service.Interfaces
{
    public interface IVoteService : IBaseService<Vote, VoteFilter>
    {

    }
}
