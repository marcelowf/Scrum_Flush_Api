using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class TeamSprintGetDTO : BaseGetDTO
    {
        public Team? Team { get; set; }
        public Sprint? Sprint { get; set; }
    }
}