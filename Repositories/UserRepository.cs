using testingApplication.Data;
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

        public void AddUser(UserDto user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserDto? GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }
    }


}