using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class CollectionController : BaseController<CollectionGetDTO, CollectionPostDTO, CollectionPutDTO, ICollectionApplicationService, CollectionFilter>
    {
        public CollectionController(ICollectionApplicationService collectionApplicationService)
            : base(collectionApplicationService)
        {
        }
    }
}
