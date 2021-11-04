using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TestApiJWT.Models;
using TestApiJWT.Services;

namespace TestApiJWT.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {

        private readonly ILessonService _service;

        public LessonsController(ILessonService service)
        {
            _service = service;
        }

        // GET: LessonsController
        [HttpGet]
        public ActionResult<IEnumerable<Lesson>> GetLessons()
        {
            var lessons = _service.GetLessons();

            return Ok(new { lessons = lessons, status = true, code = 200, msg = "get lessons successfully" });
        }

        
    }
}
