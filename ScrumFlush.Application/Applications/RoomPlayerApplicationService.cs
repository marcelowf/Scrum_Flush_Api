using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class RoomPlayerApplicationService : BaseApplicationService<RoomPlayerDTO, RoomPlayer>, IRoomPlayerApplicationService
    {
        private readonly IRoomPlayerService roomPlayerService;

        public RoomPlayerApplicationService(IMapper mapper, IRoomPlayerService roomPlayerService)
            : base(mapper, roomPlayerService)
        {
            this.roomPlayerService = roomPlayerService;
        }
    }
}
