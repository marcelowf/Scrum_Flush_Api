using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class RoomRepository : BaseRepository<Room, RoomFilter>, IRoomRepository
    {
        private readonly SqlContext sqlContext;
        public RoomRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
