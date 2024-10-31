namespace ScrumFlush.Application.Dtos.Post
{
    public class RoomPostDTO : BasePostDTO
    {
        public required Guid SprintId { get; set; }
        public required string Name { get; set; }
        
        // O codigo eu mesmo gero
        // public required string Code { get; set; }
    }
}