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
    public class TeamUserApplicationService : BaseApplicationService<TeamUserGetDTO, TeamUserPostDTO, TeamUserPutDTO, TeamUser, TeamUserFilter>, ITeamUserApplicationService
    {
        private readonly ITeamUserService teamUserService;

        public TeamUserApplicationService(IMapper mapper, ITeamUserService teamUserService)
            : base(mapper, (IBaseService<TeamUser, TeamUserFilter>)teamUserService)
        {
            this.teamUserService = teamUserService;
        }
    }
}
