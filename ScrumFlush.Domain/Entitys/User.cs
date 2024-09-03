using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class User : EntityTemplate
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required int Role { get; set; }
        public string? Position { get; set; }
        public ICollection<TeamUser>? TeamUsers { get; set; }
        public ICollection<Team>? ManagedTeams { get; set; }
        public ICollection<Player>? Players { get; set; }
        public ICollection<Room>? LeaderRooms { get; set; }
    }
}