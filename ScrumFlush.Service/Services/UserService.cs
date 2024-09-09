using ScrumFlush.Core.Interfaces;
using ScrumFlush.Domain.Entity;
using ScrumFlush.Service.Interfaces;

namespace ScrumFlush.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}