namespace ScrumFlush.Core.Filters
{
    public class CardFilter : BaseFilter
    {
        public Guid? CollectionId { get; set; }
        public float? Value { get; set; }
    }
}
