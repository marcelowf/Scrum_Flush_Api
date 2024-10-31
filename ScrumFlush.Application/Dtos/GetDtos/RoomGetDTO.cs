using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class RoomGetDTO : BaseGetDTO
    {
        public Sprint? Sprint { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public ICollection<RoomPlayer>? RoomPlayers { get; set; }
        public ICollection<Round>? RoomRounds { get; set; }
    }
}