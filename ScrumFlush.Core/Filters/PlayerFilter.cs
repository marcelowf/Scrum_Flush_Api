using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Core.Filters
{
    public class PlayerFilter : BaseFilter
    {
        public Guid? RoomPlayerId { get; set; }
        public string? Name { get; set; }
        public PlayerType? PlayerType {get; set; }
        public Guid? UserId { get; set; }
    }
}