using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace testingApplication.DTOs
{

    public class UserDto
    {
        [Key]
        public Guid Id { get; set; }

        [JsonPropertyName("username")]
        public required string Username { get; set; }

        [JsonPropertyName("email")]
        public required string Email { get; set; }

        [JsonPropertyName("password")]
        public required string Password { get; set; }
         public DateTime CreatedAt { get; set; }
         public DateTime UpdatedAt { get; set; }



        public UserDto()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }

}