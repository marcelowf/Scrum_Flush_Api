using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Post
{
    public class TeamUserPostDTO : BasePostDTO
    {
        public required Guid TeamId { get; set; }
        public required Guid UserId { get; set; }
        public required TeamUserRole TeamUserRole { get; set; }
    }
}