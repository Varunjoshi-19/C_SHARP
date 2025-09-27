using testingApplication.Interface;
using testingApplication.Models;

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
            var User = new UserDto
            {
                Username = userDto.Username,
                Email = userDto.Email,
                Password = userDto.Password
            };

            _userRepository.AddUser(User);
        }

    }



}