using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class PlayerController : BaseController<PlayerGetDTO, PlayerPostDTO, PlayerPutDTO, IPlayerApplicationService, PlayerFilter>
    {
        public PlayerController(IPlayerApplicationService playerApplicationService)
            : base(playerApplicationService)
        {
        }
    }
}
