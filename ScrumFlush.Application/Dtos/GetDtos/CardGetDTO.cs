using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class CardGetDTO : BaseGetDTO
    {
        public float? Value { get; set; }
        public ICollection<Collection>? Collection { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}
