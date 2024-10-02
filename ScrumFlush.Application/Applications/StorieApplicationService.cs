using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class StorieApplicationService : BaseApplicationService<StorieDTO, Storie>, IStorieApplicationService
    {
        private readonly IStorieService storieService;

        public StorieApplicationService(IMapper mapper, IStorieService storieService)
            : base(mapper, storieService)
        {
            this.storieService = storieService;
        }
    }
}
