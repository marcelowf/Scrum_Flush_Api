using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class PlayerService : BaseService<Player>, IPlayerService
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerService(IPlayerRepository playerRepository) : base(playerRepository)
        {
            this.playerRepository = playerRepository;
        }
    }
}