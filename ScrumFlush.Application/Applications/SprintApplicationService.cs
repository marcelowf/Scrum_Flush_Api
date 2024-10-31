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
    public class SprintApplicationService : BaseApplicationService<SprintGetDTO, SprintPostDTO, SprintPutDTO, Sprint, SprintFilter>, ISprintApplicationService
    {
        private readonly ISprintService sprintService;

        public SprintApplicationService(IMapper mapper, ISprintService sprintService)
            : base(mapper, (IBaseService<Sprint, SprintFilter>)sprintService)
        {
            this.sprintService = sprintService;
        }
    }
}
