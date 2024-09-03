using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Sprint : EntityTemplate
    {
        public required string Name { get; set; }
        public int Status { get; set; }
        public int TotalPoints { get; set; }
        public required ICollection<TeamSprint> TeamSprints { get; set; }
        public ICollection<Storie>? Stories { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}