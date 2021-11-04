using System.Collections.Generic;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        Course GetCourse(int id);
        Course UpdateCourse(int id, Course course);
        Course AddCourse(Course course);
        Course DeleteCourse(int id);
    }
}