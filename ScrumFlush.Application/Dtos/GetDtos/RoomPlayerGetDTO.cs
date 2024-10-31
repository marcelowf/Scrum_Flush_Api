using ScrumFlush.Domain.Entity;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Get
{
    public class RoomPlayerGetDTO : BaseGetDTO
    {
        public Room? Room { get; set; }
        public Player? Player { get; set; }
        public RoomPlayerRole? RoomPlayerRole { get; set; }
    }
}