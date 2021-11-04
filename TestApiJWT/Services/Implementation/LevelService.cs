using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public class LevelService : ILevelService
    {
        private readonly ApplicationDbContext _context;

        public LevelService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Level> GetLevels()
        {
            var levels = _context.Levels.ToList();
            return levels;
        }

        public Level GetLevel(int id)
        {
            var level = _context.Levels.FirstOrDefault(q => q.Id == id);
            return level;
        }

        public Level AddLevel(Level level)
        {
            _context.Levels.Add(level);
            _context.SaveChanges();

            return level;

        }

        public Level DeleteLevel(int id)
        {
            var level = _context.Levels.FirstOrDefault(q => q.Id == id);
            _context.Levels.Remove(level);
            _context.SaveChanges();
            return level;
        }


        public Level UpdateLevel(int id, Level level)
        {
            throw new NotImplementedException();
        }

    }
}
