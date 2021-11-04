using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Level Level { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<LessonItems> LessonItems { get; set; } = new List<LessonItems>();

    }
}