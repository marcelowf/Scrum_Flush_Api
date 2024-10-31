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
    public class RoomApplicationService : BaseApplicationService<RoomGetDTO, RoomPostDTO, RoomPutDTO, Room, RoomFilter>, IRoomApplicationService
    {
        private readonly IRoomService roomService;

        public RoomApplicationService(IMapper mapper, IRoomService roomService)
            : base(mapper, (IBaseService<Room, RoomFilter>)roomService)
        {
            this.roomService = roomService;
        }
    }
}
