using System.ComponentModel.DataAnnotations;
using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class User : EntityTemplate
    {
        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        [Required,MaxLength(100)]
        public required string Email { get; set; }

        [Required]
        public required int Role { get; set; }
        
        [MaxLength(50)]
        public string? Position { get; set; }

        public ICollection<TeamUser>? TeamUsers { get; set; }

        public ICollection<Player>? Players { get; set; }
    }
}