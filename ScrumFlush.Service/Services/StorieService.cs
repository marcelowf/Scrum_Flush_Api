using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class StorieService : BaseService<Storie>, IStorieService
    {
        private readonly IStorieRepository storieRepository;

        public StorieService(IStorieRepository storieRepository) : base(storieRepository)
        {
            this.storieRepository = storieRepository;
        }
    }
}