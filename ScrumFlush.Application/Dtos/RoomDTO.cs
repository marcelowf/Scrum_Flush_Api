using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class RoomDTO : BaseDTO
    {
        public Sprint? Sprint { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public ICollection<RoomPlayer>? RoomPlayers { get; set; }
        public ICollection<Round>? RoomRounds { get; set; }
    }
}