using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class RoundGetDTO : BaseGetDTO
    {
        public Room? Room { get; set; }
        public Storie? Storie { get; set; }
        public ICollection<Vote>? Votes { get; set; }
    }
}