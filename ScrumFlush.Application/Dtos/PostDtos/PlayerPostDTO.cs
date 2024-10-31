using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Post
{
    public class PlayerPostDTO : BasePostDTO
    {
        public required Guid RoomPlayerId { get; set; }
        public required string Name { get; set; }
        public required PlayerType PlayerType {get; set; }
        public Guid? UserId { get; set; }
    }
}