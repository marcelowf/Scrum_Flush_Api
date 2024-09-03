using ScrumFlush.Domain.Halper;

namespace ScrumFlush.Domain.Entity
{
    public class Collection : EntityTemplate
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Card>? Cards { get; set; }
    }
}