using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class TeamUserService : BaseService<TeamUser>, ITeamUserService
    {
        private readonly ITeamUserRepository teamuserRepository;

        public TeamUserService(ITeamUserRepository teamuserRepository) : base(teamuserRepository)
        {
            this.teamuserRepository = teamuserRepository;
        }
    }
}