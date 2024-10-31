namespace ScrumFlush.Application.Dtos.Post
{
    public class CollectionPostDTO : BasePostDTO
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}