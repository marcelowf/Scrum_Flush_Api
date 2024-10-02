using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class VoteRepository : BaseRepository<Vote>, IVoteRepository
    {
        private readonly SqlContext sqlContext;
        public VoteRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
