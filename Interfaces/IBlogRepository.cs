using testingApplication.DTOs;

namespace testingApplication.Models
{

    public interface IBlogRepository
    {

        void AddBlog(BlogDto blogDto);

}


}