using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class CollectionService : BaseService<Collection, CollectionFilter>, ICollectionService
    {
        private readonly ICollectionRepository collectionRepository;

        public CollectionService(ICollectionRepository collectionRepository) : base(collectionRepository)
        {
            this.collectionRepository = collectionRepository;
        }
    }
}