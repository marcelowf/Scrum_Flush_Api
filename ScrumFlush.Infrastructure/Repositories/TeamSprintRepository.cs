using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class TeamSprintRepository : BaseRepository<TeamSprint, TeamSprintFilter>, ITeamSprintRepository
    {
        private readonly SqlContext sqlContext;
        public TeamSprintRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
