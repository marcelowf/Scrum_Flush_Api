using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class TeamSprintService : BaseService<TeamSprint>, ITeamSprintService
    {
        private readonly ITeamSprintRepository teamsprintRepository;

        public TeamSprintService(ITeamSprintRepository teamsprintRepository) : base(teamsprintRepository)
        {
            this.teamsprintRepository = teamsprintRepository;
        }
    }
}