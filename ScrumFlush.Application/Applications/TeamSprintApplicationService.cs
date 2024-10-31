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
    public class TeamSprintApplicationService : BaseApplicationService<TeamSprintGetDTO, TeamSprintPostDTO, TeamSprintPutDTO, TeamSprint, TeamSprintFilter>, ITeamSprintApplicationService
    {
        private readonly ITeamSprintService teamSprintService;

        public TeamSprintApplicationService(IMapper mapper, ITeamSprintService teamSprintService)
            : base(mapper, (IBaseService<TeamSprint, TeamSprintFilter>)teamSprintService)
        {
            this.teamSprintService = teamSprintService;
        }
    }
}
