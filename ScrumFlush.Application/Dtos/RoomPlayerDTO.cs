using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class RoomPlayerDTO : BaseDTO
    {
        public Room? Room { get; set; }
        public Player? Player { get; set; }
        public string? PlayerRole { get; set; }
    }
}