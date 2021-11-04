using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT
{
    public class CourseService : ICourseService
    {

        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            var courses = _context.Courses.ToList();
            return courses;
        }
        public Course GetCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(q => q.Id == id);
            return course;
        }

        public Course AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();

            return course;
        }

        public Course UpdateCourse(int id, Course course)
        {

            var updated_course = _context.Courses.FirstOrDefault(q=>q.Id==id);

            updated_course.Demo = course.Demo;
            updated_course.Description = course.Description;
            updated_course.Discount = course.Discount;
            updated_course.Image = course.Image;
            updated_course.IsPaid = course.IsPaid;
            updated_course.NumberOfLessons = course.NumberOfLessons;
            updated_course.Price = course.Price;
            updated_course.ShortDescription = course.ShortDescription;
            updated_course.Title = course.Title;

            _context.SaveChanges();

            return updated_course;
        }

        public Course DeleteCourse(int id)
        {
            var course =_context.Courses.FirstOrDefault(q=>q.Id==id);
            _context.Remove(course);
            _context.SaveChanges();

            return course;
        }

    }
}