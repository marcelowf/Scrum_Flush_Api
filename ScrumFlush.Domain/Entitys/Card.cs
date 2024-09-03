using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Card : EntityTemplate
    {
        public Guid CollectionId { get; set; }
        public required Collection Collection { get; set; }
        public float? Value { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}