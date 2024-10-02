using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class TeamUserDTO : BaseDTO
    {
        public Team? Team { get; set; }
        public User? User { get; set; }
        public int? UserRole { get; set; }
    }
}