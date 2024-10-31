using ScrumFlush.Domain.Entity;
using ScrumFlush.Domain.Enums;

namespace ScrumFlush.Application.Dtos.Get
{
    public class SprintGetDTO : BaseGetDTO
    {
        public string? Name { get; set; }
        public SprintStatus? Status { get; set; }
        public int? TotalPoints { get; set; }
        public ICollection<TeamSprint>? TeamSprints { get; set; }
        public ICollection<Storie>? Stories { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}