using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class PlayerApplicationService : BaseApplicationService<PlayerDTO, Player>, IPlayerApplicationService
    {
        private readonly IPlayerService playerService;

        public PlayerApplicationService(IMapper mapper, IPlayerService playerService)
            : base(mapper, playerService)
        {
            this.playerService = playerService;
        }
    }
}
