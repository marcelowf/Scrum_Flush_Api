namespace ScrumFlush.Application.Dtos.Post
{
    public class RoundPostDTO : BasePostDTO
    {
        public required Guid RoomId { get; set; }
        public required Guid StorieId { get; set; }
    }
}