using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Dtos
{
    public class LevelReadDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}


