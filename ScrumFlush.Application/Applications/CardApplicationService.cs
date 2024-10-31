using AutoMapper;
using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class CardApplicationService : BaseApplicationService<CardGetDTO, CardPostDTO, CardPutDTO, Card, CardFilter>, ICardApplicationService
    {
        private readonly ICardService cardService;

        public CardApplicationService(IMapper mapper, ICardService cardService)
            : base(mapper, (IBaseService<Card, CardFilter>)cardService)
        {
            this.cardService = cardService;
        }
    }
}
