using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class RoundRepository : BaseRepository<Round>, IRoundRepository
    {
        private readonly SqlContext sqlContext;
        public RoundRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
