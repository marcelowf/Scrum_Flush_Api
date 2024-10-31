using ScrumFlush.Core.Filters;
using ScrumFlush.Domain.Entity;

namespace ScrumFlush.Service.Interfaces
{
    public interface IUserService : IBaseService<User, UserFilter>
    {

    }
}
