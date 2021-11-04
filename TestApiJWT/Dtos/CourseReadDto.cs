using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Dtos
{
    public class CourseReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Demo { get; set; }
        public string Image { get; set; }
        public string NumberOfLessons { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public bool IsPaid { get; set; }
        public string CreatedAt { get; set; }
        public List<ApplicationUser> Students { get; set; } = new List<ApplicationUser>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Level> Levels { get; set; } = new List<Level>();
    }
}
