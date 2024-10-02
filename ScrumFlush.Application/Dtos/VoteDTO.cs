using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Application.Dtos
{
    public class VoteDTO : BaseDTO
    {
        public Round? Round { get; set; }
        public Player? Player { get; set; }
        public Card? Card { get; set; }
    }
}