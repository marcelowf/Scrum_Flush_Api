using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Entity
{
    public class Player : BaseEntity
    {
        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        [Required]
        public required string Role { get; set; }

        [Required]
        public required int Type {get; set; }
        
        [Required]
        public required ICollection<RoomPlayer> RoomPlayers { get; set; }

        public ICollection<Vote>? Votes { get; set; }
    }
}