using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class RoomApplicationService : BaseApplicationService<RoomDTO, Room>, IRoomApplicationService
    {
        private readonly IRoomService roomService;

        public RoomApplicationService(IMapper mapper, IRoomService roomService)
            : base(mapper, roomService)
        {
            this.roomService = roomService;
        }
    }
}
