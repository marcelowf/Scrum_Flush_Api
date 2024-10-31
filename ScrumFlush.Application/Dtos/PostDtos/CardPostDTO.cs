namespace ScrumFlush.Application.Dtos.Post
{
    public class CardPostDTO : BasePostDTO
    {
        public Guid CollectionId { get; set; }
        public float? Value { get; set; }
    }
}
