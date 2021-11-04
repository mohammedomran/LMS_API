using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Dtos;
using TestApiJWT.Models;

namespace TestApiJWT.Profiles
{
    public class LevelsProfile : Profile
    {
        public LevelsProfile()
        {
            CreateMap<Level, LevelReadDto>();
            CreateMap<LevelCreateDto, Level>();
            CreateMap<LevelUpdateDto, Level>();
        }
    }
}
