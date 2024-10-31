using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class PlayerRepository : BaseRepository<Player, PlayerFilter>, IPlayerRepository
    {
        private readonly SqlContext sqlContext;
        public PlayerRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
