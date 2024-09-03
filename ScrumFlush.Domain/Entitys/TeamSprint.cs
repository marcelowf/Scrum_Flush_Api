using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class TeamSprint : EntityTemplate
    {
        public Guid TeamId { get; set; }
        public required Team Team { get; set; }
        public Guid SprintId { get; set; }
        public required Sprint Sprint { get; set; }
    }
}