namespace ScrumFlush.Application.Dtos.Put
{
    public class CardPutDTO : BasePutDTO
    {
        public Guid CollectionId { get; set; }
        public float? Value { get; set; }
    }
}
