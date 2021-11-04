using System;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Content { get; set; }
        [Required]
        public int Stars { get; set; }
        [Required]
        public ApplicationUser Student { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}