using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Dtos;
using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private readonly ILevelService _service;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public LevelsController(ILevelService service, ICourseService courseService, IMapper mapper)
        {
            _service = service;
            _courseService = courseService;
            _mapper = mapper;
        }


        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult<IEnumerable<Level>> GetLevels()
        {
            var levels = _service.GetLevels();

            return Ok(
                new { 
                    levels = levels, 
                    status = true, 
                    code = 200, 
                    msg = "get levels successfully" 
                }
            );
        }

        // GET: api/<CoursesController>
        [HttpGet("{id}")]
        public ActionResult<Level> GetLevel(int id)
        {
            var level = _service.GetLevel(id);

            return Ok(
                new { 
                    level = level, 
                    status = true, 
                    code = 200, 
                    msg = "get levels successfully" 
                }
            );
        }


        // Post: api/<CoursesController>
        [HttpPost("{id}")]
        public ActionResult<LevelReadDto> AddLevel(int id, LevelCreateDto level)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var course = _courseService.GetCourse(id);

            if (course == null)
                return NotFound();

            var levelToBeCreated = _mapper.Map<Level>(level);
            levelToBeCreated.Course = course;

            var new_level = _service.AddLevel(levelToBeCreated);

            return Ok(
                new { 
                    level = _mapper.Map<LevelReadDto>(new_level), 
                    status = true, 
                    code = 200, 
                    msg = "level stored successfully" 
                }
            );

        }
        
        // Update: api/<CoursesController>/id
        [HttpPut]
        public ActionResult<Level> UpdateLevel(Level level)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var new_level = _service.AddLevel(level);
            return Ok(new { level = new_level, status = true, code = 200, msg = "level stored successfully" });

        }

        // GET: api/<CoursesController>
        [HttpDelete("{id}")]
        public ActionResult<Level> DeleteLevel(int id)
        {
            var level = _service.DeleteLevel(id);

            return Ok(
                new
                {
                    level = level,
                    status = true,
                    code = 200,
                    msg = "level deleted successfully"
                }
            );
        }

    }
}
