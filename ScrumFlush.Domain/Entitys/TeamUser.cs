using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class TeamUser : EntityTemplate
    {
        [Required, ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public required Team Team { get; set; }

        [Required, ForeignKey("User")]
        public Guid UserId { get; set; }
        public required User User { get; set; }
        
        [Required]
        public required int UserRole { get; set; }
    }
}