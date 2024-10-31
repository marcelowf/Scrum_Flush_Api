namespace ScrumFlush.Application.Dtos.Post
{
    public class TeamPostDTO : BasePostDTO
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}