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
    public class TeamApplicationService : BaseApplicationService<TeamGetDTO, TeamPostDTO, TeamPutDTO, Team, TeamFilter>, ITeamApplicationService
    {
        private readonly ITeamService teamService;

        public TeamApplicationService(IMapper mapper, ITeamService teamService)
            : base(mapper, (IBaseService<Team, TeamFilter>)teamService)
        {
            this.teamService = teamService;
        }
    }
}
