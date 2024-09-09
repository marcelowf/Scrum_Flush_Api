using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class UserApplicationService : IBaseApplicationService<UserDTO>, IUserApplicationService
    {
        private readonly IMapper mapper;
        private readonly IUserService userService;
        public UserApplicationService(IMapper mapper, IUserService userService)
        {
            this.mapper = mapper;
            this.userService = userService;
        }

        public async Task<IList<UserDTO>> GetAll()
        {
            var list = await this.userService.GetAll();
            var listDTO = this.mapper.Map<IList<UserDTO>>(list);
            return listDTO;
        }
    }
}
