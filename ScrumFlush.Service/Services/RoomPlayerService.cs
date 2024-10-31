using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class RoomPlayerService : BaseService<RoomPlayer, RoomPlayerFilter>, IRoomPlayerService
    {
        private readonly IRoomPlayerRepository roomplayerRepository;

        public RoomPlayerService(IRoomPlayerRepository roomplayerRepository) : base(roomplayerRepository)
        {
            this.roomplayerRepository = roomplayerRepository;
        }
    }
}