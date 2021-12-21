using AutoMapper;
using webapi.dto;
using webapi.Models;

namespace webapi.Mappings
{
    public class BodyProfile:Profile
    {
        public BodyProfile()
        {
            CreateMap<Planet,PlanetReadDto>();
            CreateMap<Moon, MoonReadDto>();
            CreateMap<Star, StarReadDto>();
            CreateMap<PlanetWriteDto, Planet>();
            CreateMap<MoonWriteDto, Moon>();
            CreateMap<StarWriteDto, Star>();
            CreateMap<PlanetUpdateDto, Planet>();
            CreateMap<MoonUpdateDto, Moon>();
            CreateMap<StarUpdateDto, Star>();
        }

    }
}