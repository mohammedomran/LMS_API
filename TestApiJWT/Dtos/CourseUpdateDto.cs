using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Dtos
{
    public class CourseUpdateDto
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Demo { get; set; }
        public string Image { get; set; }
        public string NumberOfLessons { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public bool IsPaid { get; set; }
    }
}
