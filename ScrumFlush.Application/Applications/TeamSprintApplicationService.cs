using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class TeamSprintApplicationService : BaseApplicationService<TeamSprintDTO, TeamSprint>, ITeamSprintApplicationService
    {
        private readonly ITeamSprintService teamSprintService;

        public TeamSprintApplicationService(IMapper mapper, ITeamSprintService teamSprintService)
            : base(mapper, teamSprintService)
        {
            this.teamSprintService = teamSprintService;
        }
    }
}
