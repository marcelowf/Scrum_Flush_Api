using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumFlush.Domain.Halper
{
    public class EntityTemplate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id {get; set;}
        public int CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime CreatedAt {get; set;}
        public DateTime? ModifiedAt {get; set;}
        public bool IsDeleted {get; set;}
    }
}