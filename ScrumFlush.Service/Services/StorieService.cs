using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class StorieService : BaseService<Storie, StorieFilter>, IStorieService
    {
        private readonly IStorieRepository storieRepository;

        public StorieService(IStorieRepository storieRepository) : base(storieRepository)
        {
            this.storieRepository = storieRepository;
        }
    }
}