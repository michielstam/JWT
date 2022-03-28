using Catalog.Models;

namespace Catalog.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}