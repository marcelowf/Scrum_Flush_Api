using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Domain.Entity
{
    public class RoomPlayer : BaseEntity
    {
        [Required, ForeignKey("Room")]
        public Guid RoomId { get; set; }
        public required Room Room { get; set; }

        [Required, ForeignKey("Player")]
        public Guid PlayerId { get; set; }
        public required Player Player { get; set; }

        [Required ,MaxLength(15)]
        public required RoomPlayerRole RoomPlayerRole { get; set; }
    }
}