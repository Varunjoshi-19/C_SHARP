using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace testingApplication.DTOs
{
    public class AuthorDto
    {
        [JsonPropertyName("authorId")]
        public required Guid AuthorId { get; set; }

        [JsonPropertyName("authorUsername")]
        public required string AuthorUsername { get; set; }
    }

    public class BlogDto
    {

        [JsonPropertyName("category")]
        public required string Category { get; set; }

        [JsonPropertyName("authorDetails")]
        public required AuthorDto AuthorDetails { get; set; }

        [JsonPropertyName("title")]
        public required string Title { get; set; }

        [JsonPropertyName("blogContent")]
        public required string BlogContent { get; set; }



    }


}
