using testingApplication.Data;
using testingApplication.DTOs;
using testingApplication.Interface;
using testingApplication.Models;

namespace testingApplication.Repositories
{

    public class UserRepository : IUserRepository
    {
        public readonly AppDbContext _context;

        public UserRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }

        public void AddUser(UserDto userDto)
        {
            var user = new UserModel
            {
                Id = Guid.NewGuid(),
                Username = userDto.Username,
                Email = userDto.Email,
                Password = userDto.Password,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };


            _context.Add(user);
            _context.SaveChanges();
        }


    }


}