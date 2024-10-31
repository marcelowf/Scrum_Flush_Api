using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class StorieGetDTO : BaseGetDTO
    {
        public Sprint? Sprint { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
        public ICollection<Round>? Rounds { get; set; }
    }
}