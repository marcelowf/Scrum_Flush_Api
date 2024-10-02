using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class SprintDTO : BaseDTO
    {
        public string? Name { get; set; }
        public int? Status { get; set; }
        public int? TotalPoints { get; set; }
        public ICollection<TeamSprint>? TeamSprints { get; set; }
        public ICollection<Storie>? Stories { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}