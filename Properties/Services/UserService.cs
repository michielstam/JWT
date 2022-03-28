using Catalog.Models;
using Catalog.Repositories;

namespace Catalog.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o => o.Username.Equals
                (userLogin.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals
                (userLogin.Password));
                
            return user;
        }
    }
}