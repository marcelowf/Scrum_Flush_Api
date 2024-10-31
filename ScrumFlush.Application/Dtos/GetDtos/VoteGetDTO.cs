using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos.Get
{
    public class VoteGetDTO : BaseGetDTO
    {
        public Round? Round { get; set; }
        public Player? Player { get; set; }
        public Card? Card { get; set; }
    }
}