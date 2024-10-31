using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Post
{
    public class RoomPlayerPostDTO : BasePostDTO
    {
        public required Guid RoomId { get; set; }
        public required Guid PlayerId { get; set; }
        public required RoomPlayerRole RoomPlayerRole { get; set; }
    }
}