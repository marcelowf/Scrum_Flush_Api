using Microsoft.EntityFrameworkCore;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Infrastructure.Context;

namespace ScrumFlush.Infrastructure.Repositories
{
    public class CollectionRepository : BaseRepository<Collection>, ICollectionRepository
    {
        private readonly SqlContext sqlContext;
        public CollectionRepository(SqlContext _sqlcontext) : base(_sqlcontext)
        {
            this.sqlContext = _sqlcontext;
        }
    }
}
