using ScrumFlush.Domain.Entity;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Get
{
    public class PlayerGetDTO : BaseGetDTO
    {
        public User? User { get; set; }
        public string? Name { get; set; }
        public PlayerType? PlayerType {get; set; }
        public ICollection<RoomPlayer>? RoomPlayers { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}