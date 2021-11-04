using System.Collections.Generic;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface ILessonService
    {
        IEnumerable<Lesson> GetLessons();
    }
}