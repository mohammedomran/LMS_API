using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class Level
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();

    }
}