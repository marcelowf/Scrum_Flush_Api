using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Team : EntityTemplate
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Guid ManagerId { get; set; }
        public required User Manager { get; set; }
        public ICollection<TeamUser>? TeamUsers { get; set; }
        public ICollection<TeamSprint>? TeamSprints { get; set; }
    }
}