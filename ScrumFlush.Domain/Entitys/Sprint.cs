using System.ComponentModel.DataAnnotations;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Domain.Entity
{
    public class Sprint : BaseEntity
    {
        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        public SprintStatus SprintStatus { get; set; }

        [Required]
        public required ICollection<TeamSprint> TeamSprints { get; set; }

        public ICollection<Storie>? Stories { get; set; }
        
        public ICollection<Room>? Rooms { get; set; }
    }
}