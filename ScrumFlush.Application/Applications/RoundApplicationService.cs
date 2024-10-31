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
    public class RoundApplicationService : BaseApplicationService<RoundGetDTO, RoundPostDTO, RoundPutDTO, Round, RoundFilter>, IRoundApplicationService
    {
        private readonly IRoundService roundService;

        public RoundApplicationService(IMapper mapper, IRoundService roundService)
            : base(mapper, (IBaseService<Round, RoundFilter>)roundService)
        {
            this.roundService = roundService;
        }
    }
}
