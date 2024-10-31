using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class TeamUserController : BaseController<TeamUserGetDTO, TeamUserPostDTO, TeamUserPutDTO, ITeamUserApplicationService, TeamUserFilter>
    {
        public TeamUserController(ITeamUserApplicationService teamUserApplicationService)
            : base(teamUserApplicationService)
        {
        }
    }
}
