using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Core.Filters
{
    public class TeamUserFilter : BaseFilter
    {
        public Guid? TeamId { get; set; }
        public Guid? UserId { get; set; }
        public TeamUserRole? TeamUserRole { get; set; }
    }
}