using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Entity
{
    public class Vote : BaseEntity
    {
        [Required, ForeignKey("Round")]
        public Guid RoundId { get; set; }
        public required Round Round { get; set; }
        
        [Required, ForeignKey("Player")]
        public Guid PlayerId { get; set; }
        public required Player Player { get; set; }

        [Required, ForeignKey("Card")]
        public Guid CardId { get; set; }
        public required Card Card { get; set; }
    }
}