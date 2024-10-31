namespace ScrumFlush.Core.Filters
{
    public class RoomFilter : BaseFilter
    {
        public Guid? SprintId { get; set; }
        public string? Name { get; set; }
    }
}