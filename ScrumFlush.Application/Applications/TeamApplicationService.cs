using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class TeamApplicationService : BaseApplicationService<TeamDTO, Team>, ITeamApplicationService
    {
        private readonly ITeamService teamService;

        public TeamApplicationService(IMapper mapper, ITeamService teamService)
            : base(mapper, teamService)
        {
            this.teamService = teamService;
        }
    }
}
