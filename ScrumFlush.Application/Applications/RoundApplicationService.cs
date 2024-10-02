using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class RoundApplicationService : BaseApplicationService<RoundDTO, Round>, IRoundApplicationService
    {
        private readonly IRoundService roundService;

        public RoundApplicationService(IMapper mapper, IRoundService roundService)
            : base(mapper, roundService)
        {
            this.roundService = roundService;
        }
    }
}
