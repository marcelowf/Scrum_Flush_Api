namespace ScrumFlush.Application.Dtos.Post
{
    public class UserPostDTO : BasePostDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required int Role { get; set; }
        public required string Position { get; set; }
    }
}
