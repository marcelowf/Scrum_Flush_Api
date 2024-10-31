using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository<Team, TeamFilter>, ITeamRepository
    {
        private readonly SqlContext sqlContext;
        public TeamRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
