using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Vote : EntityTemplate
    {
        public Guid RoundId { get; set; }
        public required Round Round { get; set; }
        public Guid PlayerId { get; set; }
        public required Player Player { get; set; }
        public Guid CardId { get; set; }
        public required Card Card { get; set; }
    }
}