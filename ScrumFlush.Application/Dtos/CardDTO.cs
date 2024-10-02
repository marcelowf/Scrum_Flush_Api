using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class CardDTO : BaseDTO
    {
        public ICollection<Collection>? Collection { get; set; }
        public float? Value { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}
