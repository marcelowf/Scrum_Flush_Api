using System.ComponentModel.DataAnnotations;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Sprint : EntityTemplate
    {
        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        public int Status { get; set; }

        public int TotalPoints { get; set; }

        [Required]
        public required ICollection<TeamSprint> TeamSprints { get; set; }

        public ICollection<Storie>? Stories { get; set; }
        
        public ICollection<Room>? Rooms { get; set; }
    }
}