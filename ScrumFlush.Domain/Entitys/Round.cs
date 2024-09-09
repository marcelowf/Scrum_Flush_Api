using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Entity
{
    public class Round : BaseEntity
    {
        [Required, ForeignKey("Room")]
        public Guid RoomId { get; set; }
        public required Room Room { get; set; }

        [Required, ForeignKey("Storie")]
        public Guid? StorieId { get; set; }
        public Storie? Storie { get; set; }
        
        public ICollection<Vote>? Votes { get; set; }
    }
}