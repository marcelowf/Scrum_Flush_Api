using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class TeamUserRepository : BaseRepository<TeamUser, TeamUserFilter>, ITeamUserRepository
    {
        private readonly SqlContext sqlContext;
        public TeamUserRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
