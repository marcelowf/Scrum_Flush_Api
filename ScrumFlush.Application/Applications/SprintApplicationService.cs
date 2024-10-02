using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class SprintApplicationService : BaseApplicationService<SprintDTO, Sprint>, ISprintApplicationService
    {
        private readonly ISprintService sprintService;

        public SprintApplicationService(IMapper mapper, ISprintService sprintService)
            : base(mapper, sprintService)
        {
            this.sprintService = sprintService;
        }
    }
}
