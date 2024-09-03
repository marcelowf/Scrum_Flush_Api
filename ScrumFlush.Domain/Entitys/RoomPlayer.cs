using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class RoomPlayer : EntityTemplate
    {
        public Guid RoomId { get; set; }
        public required Room Room { get; set; }
        public Guid PlayerId { get; set; }
        public required Player Player { get; set; }
        public int Type {get; set; }
    }
}