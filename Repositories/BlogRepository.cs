using testingApplication.Data;
using testingApplication.Models;
using testingApplication.DTOs;

namespace testingApplication.Repositories
{

    public class BlogRepository : IBlogRepository
    {

        public readonly AppDbContext _context;
        public BlogRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void AddBlog(BlogDto blogDto)
        {
            var blog = new BlogModel
            {
                Id = Guid.NewGuid(),
                Category = blogDto.Category,
                Title = blogDto.Title,
                BlogContent = blogDto.BlogContent,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                AuthorId = blogDto.AuthorDetails.AuthorId
            };

            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }
      

    }

}