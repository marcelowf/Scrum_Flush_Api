using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class TeamUserApplicationService : BaseApplicationService<TeamUserDTO, TeamUser>, ITeamUserApplicationService
    {
        private readonly ITeamUserService teamUserService;

        public TeamUserApplicationService(IMapper mapper, ITeamUserService teamUserService)
            : base(mapper, teamUserService)
        {
            this.teamUserService = teamUserService;
        }
    }
}
