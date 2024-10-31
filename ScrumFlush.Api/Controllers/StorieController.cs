using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class StorieController : BaseController<StorieGetDTO, StoriePostDTO, StoriePutDTO, IStorieApplicationService, StorieFilter>
    {
        public StorieController(IStorieApplicationService storieApplicationService)
            : base(storieApplicationService)
        {
        }
    }
}
