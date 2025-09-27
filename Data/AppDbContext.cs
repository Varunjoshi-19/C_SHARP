using Microsoft.EntityFrameworkCore;
using testingApplication.Models;

namespace testingApplication.Data
{

    public class AppDbContext : DbContext
    {

        public DbSet<UserDto> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}

}