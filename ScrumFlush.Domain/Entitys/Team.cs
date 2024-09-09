using System.ComponentModel.DataAnnotations;

namespace ScrumFlush.Domain.Entity
{
    public class Team : BaseEntity
    {
        [Required ,MaxLength(50)]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public ICollection<TeamUser>? TeamUsers { get; set; }

        public ICollection<TeamSprint>? TeamSprints { get; set; }
    }
}