using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Put
{
    public class RoomPlayerPutDTO : BasePutDTO
    {
        public required Guid RoomId { get; set; }
        public required Guid PlayerId { get; set; }
        public required RoomPlayerRole RoomPlayerRole { get; set; }
    }
}