using AutoMapper;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumFlush.Application.Applications
{
    public abstract class BaseApplicationService<TDto, TEntity> : IBaseApplicationService<TDto>
        where TDto : class
        where TEntity : class
    {
        private readonly IMapper mapper;
        private readonly IBaseService<TEntity> baseService;

        protected BaseApplicationService(IMapper mapper, IBaseService<TEntity> baseService)
        {
            this.mapper = mapper;
            this.baseService = baseService;
        }

        public async Task<IList<TDto>> GetAll()
        {
            var list = await this.baseService.GetAll();
            return this.mapper.Map<IList<TDto>>(list);
        }

        public async Task<TDto> GetById(Guid id)
        {
            var entity = await this.baseService.GetById(id);
            return this.mapper.Map<TDto>(entity);
        }

        public async Task<TDto> Create(TDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var createdEntity = await this.baseService.Create(entity);
            return this.mapper.Map<TDto>(createdEntity);
        }

        public async Task<TDto> Update(Guid id, TDto dto)
        {
            var entity = this.mapper.Map<TEntity>(dto);
            var updatedEntity = await this.baseService.Update(id, entity);
            return this.mapper.Map<TDto>(updatedEntity);
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
