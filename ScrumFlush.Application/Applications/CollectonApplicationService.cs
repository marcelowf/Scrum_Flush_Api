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
    public class CollectionApplicationService : BaseApplicationService<CollectionGetDTO, CollectionPostDTO, CollectionPutDTO, Collection, CollectionFilter>, ICollectionApplicationService
    {
        private readonly ICollectionService collectionService;

        public CollectionApplicationService(IMapper mapper, ICollectionService collectionService)
            : base(mapper, (IBaseService<Collection, CollectionFilter>)collectionService)
        {
            this.collectionService = collectionService;
        }
    }
}
