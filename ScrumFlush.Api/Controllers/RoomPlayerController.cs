using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class RoomPlayerController : BaseController<RoomPlayerGetDTO, RoomPlayerPostDTO, RoomPlayerPutDTO, IRoomPlayerApplicationService, RoomPlayerFilter>
    {
        public RoomPlayerController(IRoomPlayerApplicationService roomPlayerApplicationService)
            : base(roomPlayerApplicationService)
        {
        }
    }
}
