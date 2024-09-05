using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Card : EntityTemplate
    {
        [Required, ForeignKey("Collection")]
        public Guid CollectionId { get; set; }
        public required Collection Collection { get; set; }

        public float? Value { get; set; }
        
        public ICollection<Vote>? Votes { get; set; }
    }
}