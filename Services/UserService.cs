using testingApplication.DTOs;
using testingApplication.Interface;

namespace testingApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;


        }

        public void RegisterUser(UserDto userDto)
        {
            _userRepository.AddUser(userDto);
        }

    }



}