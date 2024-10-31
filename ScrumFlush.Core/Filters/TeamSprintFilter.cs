namespace ScrumFlush.Core.Filters
{
    public class TeamSprintFilter : BaseFilter
    {
        public Guid? TeamId { get; set; }
        public Guid? SprintId { get; set; }
    }
}