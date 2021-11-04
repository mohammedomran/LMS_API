using System;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class LessonItems
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string VideoUrl { get; set; }
        public string content { get; set; }
        [Required]
        public string type { get; set; }
        public Lesson Lesson { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}