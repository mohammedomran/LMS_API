using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Dtos
{
    public class CourseAddDto
    {
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
        public bool IsPaid { get; set; }
    }
}
