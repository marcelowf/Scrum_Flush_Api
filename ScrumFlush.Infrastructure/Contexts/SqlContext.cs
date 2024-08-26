using Microsoft.EntityFrameworkCore;

namespace ScrumFlush.Infrastructure
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {}
    }
}
