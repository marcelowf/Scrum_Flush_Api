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
    public class UserApplicationService : BaseApplicationService<UserGetDTO, UserPostDTO, UserPutDTO, User, UserFilter>, IUserApplicationService
    {
        private readonly IUserService userService;

        public UserApplicationService(IMapper mapper, IUserService userService)
            : base(mapper, (IBaseService<User, UserFilter>)userService)
        {
            this.userService = userService;
        }
    }
}
