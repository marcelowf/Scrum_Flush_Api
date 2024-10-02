using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class TeamDTO : BaseDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<TeamUser>? TeamUsers { get; set; }
        public ICollection<TeamSprint>? TeamSprints { get; set; }
    }
}