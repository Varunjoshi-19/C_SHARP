using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testingApplication.Models
{

   [Table("blogs")]
    public class BlogModel
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public required string Category { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Title { get; set; }


        [Required]
        public required string BlogContent { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        [Required]
        public required Guid AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public  UserModel Author { get; set; }

    }

}