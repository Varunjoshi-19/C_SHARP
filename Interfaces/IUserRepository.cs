
using testingApplication.Models;

namespace testingApplication.Interface
{
    public interface IUserRepository
    {
        void AddUser(UserDto user);
        UserDto? GetUserByEmail(string email);
    }


}
