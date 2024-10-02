using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class RoundService : BaseService<Round>, IRoundService
    {
        private readonly IRoundRepository roundRepository;

        public RoundService(IRoundRepository roundRepository) : base(roundRepository)
        {
            this.roundRepository = roundRepository;
        }
    }
}