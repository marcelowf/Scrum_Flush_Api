using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class CollectionApplicationService : BaseApplicationService<CollectionDTO, Collection>, ICollectionApplicationService
    {
        private readonly ICollectionService collectionService;

        public CollectionApplicationService(IMapper mapper, ICollectionService collectionService)
            : base(mapper, collectionService)
        {
            this.collectionService = collectionService;
        }
    }
}
