using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class CollectionGetDTO : BaseGetDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Card>? Cards { get; set; }
    }
}