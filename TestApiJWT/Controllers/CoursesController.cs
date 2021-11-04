using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TestApiJWT.Dtos;
using TestApiJWT.Models;
using TestApiJWT.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        private readonly ICourseService _service;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult<IEnumerable<CourseReadDto>> GetCourses()
        {
            var courses = _service.GetCourses();

            return Ok(
                new {
                    courses = _mapper.Map<IEnumerable<CourseReadDto>>(courses),
                    status = true, 
                    code = 200, 
                    msg = "get courses successfully" 
                }
            );
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse(int id)
        {
            var course = _service.GetCourse(id);
            return Ok(
                new { 
                    course = _mapper.Map<CourseReadDto>(course), 
                    status = true, code = 200, 
                    msg = "course got successfully" 
                }
            );
        }

        // POST api/<CoursesController>
        [HttpPost]
        public ActionResult<CourseReadDto> AddCourse(CourseAddDto course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var CourseToBeCreated = _mapper.Map<Course>(course);
            var new_course = _service.AddCourse(CourseToBeCreated);
            return Ok(
                new { 
                    course = _mapper.Map<CourseReadDto>(new_course), 
                    status = true,
                    code = 200,
                    msg = "course stored successfully" 
                }
            );
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public ActionResult<CourseReadDto> UpdateCourse(int id, CourseUpdateDto course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (GetCourse(id) == null)
                return NotFound();

            var CourseToBeUpdated = _mapper.Map<Course>(course);

            var updated_course = _service.UpdateCourse(id, CourseToBeUpdated);

            return Ok(
                new { 
                    course = _mapper.Map<CourseReadDto>(updated_course), 
                    status = true, 
                    code = 200, 
                    msg = "course updated successfully" 
                }
            );

        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Course> DeleteCourse(int id)
        {
            var course = _service.DeleteCourse(id);
            return Ok(
                new { 
                    course = course, 
                    status = true, 
                    code = 200, 
                    msg = "course deleted successfully" 
                }
            );
        }


    }
}
