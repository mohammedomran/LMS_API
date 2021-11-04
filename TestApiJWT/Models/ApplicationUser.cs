using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}