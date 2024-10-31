namespace ScrumFlush.Application.Dtos.Post
{
    public class TeamSprintPostDTO : BasePostDTO
    {
        public required Guid TeamId { get; set; }
        public required Guid SprintId { get; set; }
    }
}