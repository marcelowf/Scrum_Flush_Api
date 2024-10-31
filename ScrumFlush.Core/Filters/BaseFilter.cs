namespace ScrumFlush.Core.Filters
{
    public class BaseFilter
    {
        public Guid? Id { get; set; }
        public Guid? CreatedById { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
