namespace ScrumFlush.Application.Dtos.Post
{
    public class VotePostDTO : BasePostDTO
    {
        public required Guid RoundId { get; set; }
        public required Guid Player { get; set; }
        public required Guid Card { get; set; }
    }
}