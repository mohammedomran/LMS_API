using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public class LessonService : ILessonService
    {

        private readonly ApplicationDbContext _context;

        public LessonService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Lesson> GetLessons()
        {
            var lessons = _context.Lessons.ToList();
            return lessons;
        }

    }
}
