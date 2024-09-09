using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Infrastructure.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<Vote> Vote { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamUser> TeamUser { get; set; }
        public DbSet<TeamSprint> TeamSprint { get; set; }
        public DbSet<Storie> Storie { get; set; }
        public DbSet<Sprint> Sprint { get; set; }
        public DbSet<Round> Round { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomPlayer> RoomPlayer { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<Card> Card { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Vote>()
                .HasOne(p => p.Round)
                .WithMany(p => p.Votes)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Vote>()
                .HasOne(p => p.Player)
                .WithMany(p => p.Votes)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Vote>()
                .HasOne(p => p.Card)
                .WithMany(p => p.Votes)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamUser>()
                .HasOne(p => p.Team)
                .WithMany(p => p.TeamUsers)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeamUser>()
                .HasOne(p => p.User)
                .WithMany(p => p.TeamUsers)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<TeamSprint>()
                .HasOne(p => p.Team)
                .WithMany(p => p.TeamSprints)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeamSprint>()
                .HasOne(p => p.Sprint)
                .WithMany(p => p.TeamSprints)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<Storie>()
                .HasOne(p => p.Sprint)
                .WithMany(p => p.Stories)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<Round>()
                .HasOne(p => p.Storie)
                .WithMany(p => p.Rounds)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Round>()
                .HasOne(p => p.Room)
                .WithMany(p => p.RoomRounds)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<RoomPlayer>()
                .HasOne(p => p.Player)
                .WithMany(p => p.RoomPlayers)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<RoomPlayer>()
                .HasOne(p => p.Room)
                .WithMany(p => p.RoomPlayers)
                .OnDelete(DeleteBehavior.Restrict);
                
            modelBuilder.Entity<Room>()
                .HasOne(p => p.Sprint)
                .WithMany(p => p.Rooms)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Player>()
                .HasOne(p => p.User)
                .WithMany(p => p.Players)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Card>()
                .HasOne(p => p.Collection)
                .WithMany(p => p.Cards)
                .OnDelete(DeleteBehavior.Restrict);
                        
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .HasQueryFilter(CreateQueryFilter(entityType.ClrType));
                }
            }
        }
   
        private static LambdaExpression CreateQueryFilter(Type entityType)
        {
            var parameter = Expression.Parameter(entityType, "e");

            var isDeletedProperty = Expression.Property(parameter, "IsDeleted");
            var isDeletedFalse = Expression.Equal(isDeletedProperty, Expression.Constant(false));

            var createdByIdProperty = Expression.Property(parameter, "CreatedById");
            var createdByIdGreaterThanZero = Expression.GreaterThan(createdByIdProperty, Expression.Constant(0));

            var combinedFilter = Expression.AndAlso(isDeletedFalse, createdByIdGreaterThanZero);

            return Expression.Lambda(combinedFilter, parameter);
        }
    }
}