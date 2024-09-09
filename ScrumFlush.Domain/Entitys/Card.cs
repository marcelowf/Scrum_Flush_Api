using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Entity
{
    public class Card : BaseEntity
    {
        [Required, ForeignKey("Collection")]
        public Guid CollectionId { get; set; }
        public required Collection Collection { get; set; }

        public float? Value { get; set; }
        
        public ICollection<Vote>? Votes { get; set; }
    }
}