using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class StorieDTO : BaseDTO
    {
        public Sprint? Sprint { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? Points { get; set; }
        public ICollection<Round>? Rounds { get; set; }
    }
}