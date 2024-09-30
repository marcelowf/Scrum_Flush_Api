using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
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

        public async Task<UserDTO> GetById(Guid id)
        {
            var user = await this.userService.GetById(id);
            var userDTO = this.mapper.Map<UserDTO>(user);
            return userDTO;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var userEntity = this.mapper.Map<User>(userDTO);
            var userCreated = await this.userService.Create(userEntity);
            return this.mapper.Map<UserDTO>(userCreated);
        }

        public async Task<UserDTO> Update(Guid id, UserDTO userDTO)
        {
            var userEntity = this.mapper.Map<User>(userDTO);
            var userUpdated = await this.userService.Update(id, userEntity);
            return this.mapper.Map<UserDTO>(userUpdated);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await this.userService.Delete(id);
        }

        public async Task<bool> SoftDelete(Guid id)
        {
            return await this.userService.SoftDelete(id);
        }
    }
}
