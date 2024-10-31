using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class VoteRepository : BaseRepository<Vote, VoteFilter>, IVoteRepository
    {
        private readonly SqlContext sqlContext;
        public VoteRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
