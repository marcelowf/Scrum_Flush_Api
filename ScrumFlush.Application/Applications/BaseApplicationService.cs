using AutoMapper;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public abstract class BaseApplicationService<TGetDto, TPostDto, TPutDto, TEntity, TFilters> : IBaseApplicationService<TGetDto, TPostDto, TPutDto, TFilters>
        where TGetDto : class
        where TPostDto : class
        where TPutDto : class
        where TEntity : class
        where TFilters : class
    {
        private readonly IMapper mapper;
        private readonly IBaseService<TEntity, TFilters> baseService;

        protected BaseApplicationService(IMapper mapper, IBaseService<TEntity, TFilters> baseService)
        {
            this.mapper = mapper;
            this.baseService = baseService;
        }

        public async Task<IList<TGetDto>> GetAll(TFilters filters)
        {
            var entities = await this.baseService.GetAll(filters);
            return this.mapper.Map<IList<TGetDto>>(entities);
        }

        public async Task<TGetDto> GetById(Guid id)
        {
            var entity = await this.baseService.GetById(id);
            return this.mapper.Map<TGetDto>(entity);
        }

        public async Task<TGetDto> Create(TPostDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var createdEntity = await this.baseService.Create((Guid)typeof(TPostDto).GetProperty("AuthorId").GetValue(dto), entity);
            return this.mapper.Map<TGetDto>(createdEntity);
        }

        public async Task<TGetDto> Update(Guid id, TPutDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var updatedEntity = await this.baseService.Update((Guid)typeof(TPostDto).GetProperty("AuthorId").GetValue(dto), id, entity);
            return this.mapper.Map<TGetDto>(updatedEntity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await this.baseService.Delete(id);
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            return await this.baseService.SoftDelete(id);
        }
    }
}
