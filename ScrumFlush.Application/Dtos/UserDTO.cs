using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class UserDTO : BaseDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required int Role { get; set; }
        public string? Position { get; set; }
        public ICollection<TeamUser>? TeamUsers { get; set; }
        public ICollection<Player>? Players { get; set; }
    }
}
