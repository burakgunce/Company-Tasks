using AutoMapper;
using RehberWebApi.Models.DTOs;
using RehberWebApi.Models.Entities;

namespace RehberWebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RehberDto, Rehber>();
        }
    }
}
