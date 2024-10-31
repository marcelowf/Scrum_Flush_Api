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
    public class RoomPlayerApplicationService : BaseApplicationService<RoomPlayerGetDTO, RoomPlayerPostDTO, RoomPlayerPutDTO, RoomPlayer, RoomPlayerFilter>, IRoomPlayerApplicationService
    {
        private readonly IRoomPlayerService roomPlayerService;

        public RoomPlayerApplicationService(IMapper mapper, IRoomPlayerService roomPlayerService)
            : base(mapper, (IBaseService<RoomPlayer, RoomPlayerFilter>)roomPlayerService)
        {
            this.roomPlayerService = roomPlayerService;
        }
    }
}
