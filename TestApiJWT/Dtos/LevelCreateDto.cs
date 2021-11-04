using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Dtos
{
    public class LevelCreateDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        public Course Course { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
