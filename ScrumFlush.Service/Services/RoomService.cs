using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class RoomService : BaseService<Room>, IRoomService
    {
        private readonly IRoomRepository roomRepository;

        public RoomService(IRoomRepository roomRepository) : base(roomRepository)
        {
            this.roomRepository = roomRepository;
        }
    }
}