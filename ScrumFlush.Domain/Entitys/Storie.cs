using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Storie : EntityTemplate
    {
        [Required, ForeignKey("Sprint")]
        public Guid? SprintId { get; set; }
        public Sprint? Sprint { get; set; }
        
        [Required ,MaxLength(50)]
        public required string Name { get; set; }
        
        [MaxLength(500)]
        public string? Description { get; set; }

        public float? Points { get; set; }

        public ICollection<Round>? Rounds { get; set; }
    }
}