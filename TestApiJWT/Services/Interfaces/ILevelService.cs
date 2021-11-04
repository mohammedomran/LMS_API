using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface ILevelService
    {
        IEnumerable<Level> GetLevels();
        Level GetLevel(int id);
        Level AddLevel(Level level);
        Level UpdateLevel(int id, Level level);
        Level DeleteLevel(int id);
    }
}
