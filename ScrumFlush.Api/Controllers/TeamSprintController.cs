using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class TeamSprintController : BaseController<TeamSprintGetDTO, TeamSprintPostDTO, TeamSprintPutDTO, ITeamSprintApplicationService, TeamSprintFilter>
    {
        public TeamSprintController(ITeamSprintApplicationService teamSprintApplicationService)
            : base(teamSprintApplicationService)
        {
        }
    }
}
