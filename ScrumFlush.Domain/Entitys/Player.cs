using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Player : EntityTemplate
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public required string Role { get; set; }
        public required ICollection<RoomPlayer> RoomPlayers { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}