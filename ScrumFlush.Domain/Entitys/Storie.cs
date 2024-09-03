using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Storie : EntityTemplate
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
        public Guid? SprintId { get; set; }
        public Sprint? Sprint { get; set; }
        public ICollection<Round>? Rounds { get; set; }
    }
}