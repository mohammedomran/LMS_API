using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{

    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Demo { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string NumberOfLessons { get; set; }
        [Required]
        public string Price { get; set; }
        public string Discount { get; set; }
        public bool IsPaid { get; set; } = true;
        [Required]
        public string CreatedAt { get; set; } = DateTime.Now.ToString();
        public List<ApplicationUser> Students { get; set; } = new List<ApplicationUser>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Level> Levels { get; set; } = new List<Level> ();
    }
}
