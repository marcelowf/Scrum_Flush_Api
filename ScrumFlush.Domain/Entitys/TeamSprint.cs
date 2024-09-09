using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Entity
{
    public class TeamSprint : BaseEntity
    {
        [Required, ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public required Team Team { get; set; }
        
        [Required, ForeignKey("Sprint")]
        public Guid SprintId { get; set; }
        public required Sprint Sprint { get; set; }
    }
}