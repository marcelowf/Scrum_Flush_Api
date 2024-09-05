using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Halper
{
    public class EntityTemplate
    {
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int CreatedById { get; set; }

        public int? ModifiedById { get; set; }

        [Required ,DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedAt { get; set; }
        
        [Required]
        public bool IsDeleted { get; set; }
    }
}