using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class PlayerDTO : BaseDTO
    {
        public User? User { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int? Type {get; set; }
        public ICollection<RoomPlayer>? RoomPlayers { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}