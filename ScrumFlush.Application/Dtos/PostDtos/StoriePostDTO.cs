namespace ScrumFlush.Application.Dtos.Post
{
    public class StoriePostDTO : BasePostDTO
    {
        public required Guid SprintId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
    }
}