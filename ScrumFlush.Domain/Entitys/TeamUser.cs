using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Domain.Entity
{
    public class TeamUser : BaseEntity
    {
        [Required, ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public required Team Team { get; set; }

        [Required, ForeignKey("User")]
        public Guid UserId { get; set; }
        public required User User { get; set; }

        [Required]
        public required TeamUserRole TeamUserRole { get; set; }
    }
}