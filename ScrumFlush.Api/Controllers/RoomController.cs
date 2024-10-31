using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class RoomController : BaseController<RoomGetDTO, RoomPostDTO, RoomPutDTO, IRoomApplicationService, RoomFilter>
    {
        public RoomController(IRoomApplicationService roomApplicationService)
            : base(roomApplicationService)
        {
        }
    }
}
