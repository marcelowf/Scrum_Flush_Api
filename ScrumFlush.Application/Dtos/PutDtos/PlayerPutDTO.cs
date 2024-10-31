using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Put
{
    public class PlayerPutDTO : BasePutDTO
    {
        public required Guid RoomPlayerId { get; set; }
        public string? Name { get; set; }
        public PlayerType? PlayerType {get; set; }
        public Guid? UserId { get; set; }
    }
}