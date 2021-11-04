using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Dtos;
using TestApiJWT.Models;

namespace TestApiJWT.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseReadDto>();
            CreateMap<CourseAddDto, Course>();
            CreateMap<CourseUpdateDto, Course>();
        }
    }
}
