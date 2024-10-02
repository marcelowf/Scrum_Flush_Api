using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class TeamSprintDTO : BaseDTO
    {
        public Team? Team { get; set; }
        public Sprint? Sprint { get; set; }
    }
}