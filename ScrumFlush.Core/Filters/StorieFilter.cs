namespace ScrumFlush.Core.Filters
{
    public class StorieFilter : BaseFilter
    {
        public Guid? SprintId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
    }
}