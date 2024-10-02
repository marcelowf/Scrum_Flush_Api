using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class CardService : BaseService<Card>, ICardService
    {
        private readonly ICardRepository cardRepository;

        public CardService(ICardRepository cardRepository) : base(cardRepository)
        {
            this.cardRepository = cardRepository;
        }
    }
}