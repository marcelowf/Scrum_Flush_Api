using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class TeamUser : EntityTemplate
    {
        public Guid TeamId { get; set; }
        public required Team Team { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }
    }
}