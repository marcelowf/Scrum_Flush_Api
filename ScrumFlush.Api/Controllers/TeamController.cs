using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class TeamController : BaseController<TeamGetDTO, TeamPostDTO, TeamPutDTO, ITeamApplicationService, TeamFilter>
    {
        public TeamController(ITeamApplicationService teamApplicationService)
            : base(teamApplicationService)
        {
        }
    }
}
