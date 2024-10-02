using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class CollectionDTO : BaseDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Card>? Cards { get; set; }
    }
}