using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class StorieRepository : BaseRepository<Storie>, IStorieRepository
    {
        private readonly SqlContext sqlContext;
        public StorieRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
