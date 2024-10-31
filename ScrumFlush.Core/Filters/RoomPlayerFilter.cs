using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Core.Filters
{
    public class RoomPlayerFilter : BaseFilter
    {
        public Guid? RoomId { get; set; }
        public Guid? PlayerId { get; set; }
        public RoomPlayerRole? RoomPlayerRole { get; set; }
    }
}