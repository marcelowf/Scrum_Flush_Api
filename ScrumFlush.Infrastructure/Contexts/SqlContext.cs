using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Domain.Halper;

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
                .WithMany()
                .HasForeignKey(p => p.RoundId)
                .IsRequired();
            modelBuilder.Entity<Vote>()
                .HasOne(p => p.Player)
                .WithMany()
                .HasForeignKey(p => p.PlayerId)
                .IsRequired();
            modelBuilder.Entity<Vote>()
                .HasOne(p => p.Card)
                .WithMany()
                .HasForeignKey(p => p.CardId)
                .IsRequired();

            modelBuilder.Entity<Team>()
                .HasOne(p => p.Manager)
                .WithMany()
                .HasForeignKey(p => p.ManagerId)
                .IsRequired();

            modelBuilder.Entity<TeamUser>()
                .HasOne(p => p.Team)
                .WithMany()
                .HasForeignKey(p => p.TeamId)
                .IsRequired();
            modelBuilder.Entity<TeamUser>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .IsRequired();
                
            modelBuilder.Entity<TeamSprint>()
                .HasOne(p => p.Team)
                .WithMany()
                .HasForeignKey(p => p.TeamId)
                .IsRequired();
            modelBuilder.Entity<TeamSprint>()
                .HasOne(p => p.Sprint)
                .WithMany()
                .HasForeignKey(p => p.SprintId)
                .IsRequired();
                
            modelBuilder.Entity<Storie>()
                .HasOne(p => p.Sprint)
                .WithMany()
                .HasForeignKey(p => p.SprintId)
                .IsRequired();
                
            modelBuilder.Entity<Round>()
                .HasOne(p => p.Storie)
                .WithMany()
                .HasForeignKey(p => p.StorieId)
                .IsRequired();
            modelBuilder.Entity<Round>()
                .HasOne(p => p.Room)
                .WithMany()
                .HasForeignKey(p => p.RoomId)
                .IsRequired();
                
            modelBuilder.Entity<Room>()
                .HasOne(p => p.Leader)
                .WithMany()
                .HasForeignKey(p => p.LeaderId)
                .IsRequired();
            modelBuilder.Entity<Room>()
                .HasOne(p => p.Sprint)
                .WithMany()
                .HasForeignKey(p => p.SprintId)
                .IsRequired();
                
            modelBuilder.Entity<RoomPlayer>()
                .HasOne(p => p.Player)
                .WithMany()
                .HasForeignKey(p => p.PlayerId)
                .IsRequired();
            modelBuilder.Entity<RoomPlayer>()
                .HasOne(p => p.Room)
                .WithMany()
                .HasForeignKey(p => p.RoomId)
                .IsRequired();
                
            modelBuilder.Entity<Player>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .IsRequired();
                
            modelBuilder.Entity<Card>()
                .HasOne(p => p.Collection)
                .WithMany()
                .HasForeignKey(p => p.CollectionId)
                .IsRequired();
                        
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(EntityTemplate).IsAssignableFrom(entityType.ClrType))
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