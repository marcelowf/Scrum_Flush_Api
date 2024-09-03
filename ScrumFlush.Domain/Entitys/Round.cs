using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Round : EntityTemplate
    {
        public Guid RoomId { get; set; }
        public required Room Room { get; set; }
        public Guid? StorieId { get; set; }
        public Storie? Storie { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}