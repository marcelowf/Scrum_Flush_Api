using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class CardApplicationService : BaseApplicationService<CardDTO, Card>, ICardApplicationService
    {
        private readonly ICardService cardService;

        public CardApplicationService(IMapper mapper, ICardService cardService)
            : base(mapper, cardService)
        {
            this.cardService = cardService;
        }
    }
}
