namespace ScrumFlush.Application.Interfaces
{
    public interface IBaseApplicationService<TGetDto, TPostDto, TPutDto, TFilters> 
        where TGetDto : class
        where TPostDto : class
        where TPutDto : class
        where TFilters : class
    {
        Task<IList<TGetDto>> GetAll(TFilters filters);
        Task<TGetDto> GetById(Guid id);
        Task<TGetDto> Create(TPostDto entity);
        Task<TGetDto> Update(Guid id, TPutDto entity);
        Task<bool> Delete(Guid id);
        Task<bool> SoftDelete(Guid id);
    }
}
