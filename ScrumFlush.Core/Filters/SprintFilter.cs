using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Core.Filters
{
    public class SprintFilter : BaseFilter
    {
        public string? Name { get; set; }
        public SprintStatus? Status { get; set; }
    }
}