using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Post
{
    public class SprintPostDTO : BasePostDTO
    {
        public required string Name { get; set; }
        public required SprintStatus Status { get; set; }
    }
}