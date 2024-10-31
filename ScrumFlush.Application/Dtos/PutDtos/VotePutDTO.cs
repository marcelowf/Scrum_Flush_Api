namespace ScrumFlush.Application.Dtos.Put
{
    public class VotePutDTO : BasePutDTO
    {
        public required Guid RoundId { get; set; }
        public required Guid Player { get; set; }
        public required Guid Card { get; set; }
    }
}