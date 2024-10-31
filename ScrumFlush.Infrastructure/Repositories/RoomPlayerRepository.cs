using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class RoomPlayerRepository : BaseRepository<RoomPlayer, RoomPlayerFilter>, IRoomPlayerRepository
    {
        private readonly SqlContext sqlContext;
        public RoomPlayerRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
