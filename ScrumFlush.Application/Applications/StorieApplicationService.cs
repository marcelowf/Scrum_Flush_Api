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
    public class StorieApplicationService : BaseApplicationService<StorieGetDTO, StoriePostDTO, StoriePutDTO, Storie, StorieFilter>, IStorieApplicationService
    {
        private readonly IStorieService storieService;

        public StorieApplicationService(IMapper mapper, IStorieService storieService)
            : base(mapper, (IBaseService<Storie, StorieFilter>)storieService)
        {
            this.storieService = storieService;
        }
    }
}
