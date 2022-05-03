using System;
using System.ComponentModel.DataAnnotations;

namespace GenesisBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250, ErrorMessage="The {0} must be at least {2} characters and no more than {1} characters long.", MinimumLength = 2)]
        public string Title { get; set; } = string.Empty;


        [Required]
        public string Abstract { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime? Updated { get; set; }
    }
}
