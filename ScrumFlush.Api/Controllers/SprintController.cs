using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class SprintController : BaseController<SprintGetDTO, SprintPostDTO, SprintPutDTO, ISprintApplicationService, RoundFilter>
    {
        public SprintController(ISprintApplicationService sprintApplicationService)
            : base(sprintApplicationService)
        {
        }
    }
}
