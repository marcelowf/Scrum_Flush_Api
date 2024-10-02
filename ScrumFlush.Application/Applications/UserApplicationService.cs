using AutoMapper;
using ScrumFlush.Application.Dtos;
using ScrumFlush.Application.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Application.Applications
{
    public class UserApplicationService : BaseApplicationService<UserDTO, User>, IUserApplicationService
    {
        private readonly IUserService userService;

        public UserApplicationService(IMapper mapper, IUserService userService)
            : base(mapper, userService)
        {
            this.userService = userService;
        }
    }
}
