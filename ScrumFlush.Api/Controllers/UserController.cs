using ScrumFlush.Application.Dtos.Get;
using ScrumFlush.Application.Dtos.Post;
using ScrumFlush.Application.Dtos.Put;
using ScrumFlush.Core.Filters;
using ScrumFlush.Application.Interfaces;

namespace ScrumFlush.Api.Controllers
{
    public class UserController : BaseController<UserGetDTO, UserPostDTO, UserPutDTO, IUserApplicationService, UserFilter>
    {
        public UserController(IUserApplicationService userApplicationService)
            : base(userApplicationService)
        {
        }
    }
}
