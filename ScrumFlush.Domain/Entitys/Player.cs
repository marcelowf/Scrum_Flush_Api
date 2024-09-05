using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Player : EntityTemplate
    {
        [Required, ForeignKey("User")]
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        [Required]
        public required string Role { get; set; }

        [Required]
        public required  int Type {get; set; }
        
        [Required]
        public required ICollection<RoomPlayer> RoomPlayers { get; set; }

        public ICollection<Vote>? Votes { get; set; }
    }
}