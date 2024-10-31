using ScrumFlush.Domain.Entity;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Get
{
    public class TeamUserGetDTO : BaseGetDTO
    {
        public Team? Team { get; set; }
        public User? User { get; set; }
        public TeamUserRole? TeamUserRole { get; set; }
    }
}