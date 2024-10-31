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
    public class PlayerApplicationService : BaseApplicationService<PlayerGetDTO, PlayerPostDTO, PlayerPutDTO, Player, PlayerFilter>, IPlayerApplicationService
    {
        private readonly IPlayerService playerService;

        public PlayerApplicationService(IMapper mapper, IPlayerService playerService)
            : base(mapper, (IBaseService<Player, PlayerFilter>)playerService)
        {
            this.playerService = playerService;
        }
    }
}
