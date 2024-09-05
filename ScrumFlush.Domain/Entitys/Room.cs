using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Room : EntityTemplate
    {
        [Required, ForeignKey("Sprint")]
        public Guid SprintId { get; set; }
        public required Sprint Sprint { get; set; }

        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        [Required ,MaxLength(500)]
        public required string Code { get; set; }

        [Required]
        public required ICollection<RoomPlayer> RoomPlayers { get; set; }

        public ICollection<Round>? RoomRounds { get; set; }
    }
}