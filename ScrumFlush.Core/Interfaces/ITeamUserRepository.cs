using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Core.Interfaces
{
    public interface ITeamUserRepository : IBaseRepository<TeamUser, TeamUserFilter>
    {
        
    }
}
