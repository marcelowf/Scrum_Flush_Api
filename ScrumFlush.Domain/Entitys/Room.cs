using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Room : EntityTemplate
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public Guid LeaderId { get; set; }
        public required User Leader { get; set; }
        public Guid? SprintId { get; set; }
        public Sprint? Sprint { get; set; }
        public ICollection<RoomPlayer>? RoomPlayers { get; set; }
        public ICollection<Round>? Rounds { get; set; }
    }
}