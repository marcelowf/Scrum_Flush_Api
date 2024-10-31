using ScrumFlush.Core.Filters;
using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class SprintService : BaseService<Sprint, SprintFilter>, ISprintService
    {
        private readonly ISprintRepository sprintRepository;

        public SprintService(ISprintRepository sprintRepository) : base(sprintRepository)
        {
            this.sprintRepository = sprintRepository;
        }
    }
}