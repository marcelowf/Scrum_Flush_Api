using System.ComponentModel.DataAnnotations;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Collection : EntityTemplate
    {
        [Required, MaxLength(50)]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public ICollection<Card>? Cards { get; set; }
    }
}