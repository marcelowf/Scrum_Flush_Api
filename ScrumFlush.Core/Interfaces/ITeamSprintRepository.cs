using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Core.Interfaces
{
    public interface ITeamSprintRepository : IBaseRepository<TeamSprint, TeamSprintFilter>
    {
        
    }
}
