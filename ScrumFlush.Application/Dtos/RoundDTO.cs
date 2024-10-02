using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class RoundDTO : BaseDTO
    {
        public Room? Room { get; set; }
        public Storie? Storie { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}